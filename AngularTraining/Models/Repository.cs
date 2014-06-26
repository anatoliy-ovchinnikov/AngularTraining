namespace AngularStart.Models
{
    using System.Collections.Generic;

    public class Repository
    {
        public List<Category> categories = new List<Category>
        {
            new Category
            {
                Id = 0, Title = "All", ImageUrl = "",
                Brands = new List<Brand>
                {
                    new Brand{ Id = 5,  Title = "CDON",  ImageUrl = "http://static.mikz.com/ContentData/2bd9eaff-dd95-4174-9ca4-a0e4010d499d/f92f4ccf-1420-4bc6-adb8-a0e7009310ce/small_ChaFeIm_7e61326e-5373-4e5e-8fbd-516e8ca1d1e0.png"},
                    new Brand{ Id = 6,  Title = "Bokia",  ImageUrl = "http://static.mikz.com/ContentData/a8f10a6a-bfd8-48f7-9f5a-a0fc008b7c01/f2ccc887-e5e9-46e7-a2d7-a10001131e35/small_ChaFeIm_edb09aea-b33e-43a9-900f-7b72e4493fb9.png"},
                    new Brand{ Id = 1,  Title = "Kulturbolaget",  ImageUrl = "http://static.mikz.com/ContentData/dabb2dfb-4280-4c85-9ee4-a03000a4e331/41b74e05-cb9a-44a5-9a1b-a04700ae88a8/small_ChaFeIm_d34e5be3-0e62-4776-b305-d7216274423a.png"},
                    new Brand{ Id = 2,  Title = "O'Learys",  ImageUrl = "http://static.mikz.com/ContentData/0a78ab04-40a0-4af0-9a5f-9fc900bec5db/ccf0cf76-c576-47f2-a3f7-a06f00f7628a/small_ChaFeIm_044dec46-e702-49db-ac70-f6bd33402b75.png"},
                    new Brand{ Id = 3,  Title = "Big Slap",  ImageUrl = "http://static.mikz.com/ContentData/3998f96a-5f3e-4021-9d83-a1c7014303bc/2a5fe608-fbb5-48eb-baf1-a1ce00e7e33c/small_ChaFeIm_e6cd3478-b2ac-40b7-bb66-6553a43710de.png"},
                    new Brand{ Id = 4,  Title = "Babel",  ImageUrl = "http://static.mikz.com/ContentData/36fb2252-70ce-4fd2-85bb-a25300a97ba9/fe894a7e-28db-448d-9d1b-a25300dbc83a/small_ChaFeIm_47bb38a0-7c3c-4a42-b39b-ec0b37bb15d5.jpg"}
                }
            },
            new Category
            {
                Id = 1, Title = "BarNightclubs", ImageUrl = "http://www.mikz.com/picto/BarNightclubs.png",
                Brands = new List<Brand>
                {
                    new Brand{ Id = 5,  Title = "CDON",  ImageUrl = "http://static.mikz.com/ContentData/2bd9eaff-dd95-4174-9ca4-a0e4010d499d/f92f4ccf-1420-4bc6-adb8-a0e7009310ce/small_ChaFeIm_7e61326e-5373-4e5e-8fbd-516e8ca1d1e0.png"},
                    new Brand{ Id = 6,  Title = "Bokia",  ImageUrl = "http://static.mikz.com/ContentData/a8f10a6a-bfd8-48f7-9f5a-a0fc008b7c01/f2ccc887-e5e9-46e7-a2d7-a10001131e35/small_ChaFeIm_edb09aea-b33e-43a9-900f-7b72e4493fb9.png"}
                }
                
            },
            new Category
            {
                Id = 2, Title = "Books", ImageUrl = "http://www.mikz.com/picto/Books.png",
                Brands = new List<Brand>
                {
                    new Brand{ Id = 1,  Title = "Kulturbolaget",  ImageUrl = "http://static.mikz.com/ContentData/dabb2dfb-4280-4c85-9ee4-a03000a4e331/41b74e05-cb9a-44a5-9a1b-a04700ae88a8/small_ChaFeIm_d34e5be3-0e62-4776-b305-d7216274423a.png"},
                    new Brand{ Id = 2,  Title = "O'Learys",  ImageUrl = "http://static.mikz.com/ContentData/0a78ab04-40a0-4af0-9a5f-9fc900bec5db/ccf0cf76-c576-47f2-a3f7-a06f00f7628a/small_ChaFeIm_044dec46-e702-49db-ac70-f6bd33402b75.png"},
                    new Brand{ Id = 3,  Title = "Big Slap",  ImageUrl = "http://static.mikz.com/ContentData/3998f96a-5f3e-4021-9d83-a1c7014303bc/2a5fe608-fbb5-48eb-baf1-a1ce00e7e33c/small_ChaFeIm_e6cd3478-b2ac-40b7-bb66-6553a43710de.png"},
                    new Brand{ Id = 4,  Title = "Babel",  ImageUrl = "http://static.mikz.com/ContentData/36fb2252-70ce-4fd2-85bb-a25300a97ba9/fe894a7e-28db-448d-9d1b-a25300dbc83a/small_ChaFeIm_47bb38a0-7c3c-4a42-b39b-ec0b37bb15d5.jpg"}
                }
            },
            new Category{ Id = 3, Title = "Culture", ImageUrl = "http://www.mikz.com/picto/Culture.png"},
            new Category{ Id = 4, Title = "Deals", ImageUrl = "http://www.mikz.com/picto/Deals.png"}
        };
    }
}