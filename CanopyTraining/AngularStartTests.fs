module BrandCountTest
open canopy
open runner
open System


start firefox

"go to categories, click on specified category, assert brands count" &&& fun _ ->

    url "http://localhost:4416/#/category/"

    click "#navList_2"

    notDisplayed "#myModal"

    count "#brandItem" 2

"go to brand edit page, change title, check validation on this page" &&& fun _ ->

    url "http://localhost:4416/#/category/"

    click (first "#brandItem")

    clear "#Title"

    click "#updateBtn"

    on "http://localhost:4416/#/edit/1/redirect/1"


"got to brand edit page, click cansel, check url" &&& fun _ ->

    url "http://localhost:4416/#/edit/1/redirect/1"

    click "#btnCancel"

    on "http://localhost:4416/#/category/1"

run()

printfn "press [enter] to exit"
System.Console.ReadLine() |> ignore

quit()