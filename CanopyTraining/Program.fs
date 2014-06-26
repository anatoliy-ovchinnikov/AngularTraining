open canopy
open runner
open System


start firefox

"first test" &&& fun _ ->

    url "http://localhost:4416/#/category/"

    click "#navList_3"

    notDisplayed "#myModal"

    click "#navList_4"

run()

printfn "press [enter] to exit"
System.Console.ReadLine() |> ignore

quit()