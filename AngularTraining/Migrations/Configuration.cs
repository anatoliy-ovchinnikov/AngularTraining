namespace AngularStart.Migrations
{
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<DataContext>
    {
        private readonly Category category = new Category { Id = 1, Title = "All", ImageUrl = "" };
        private readonly Category category1 = new Category { Id = 2, Title = "BarNightclubs", ImageUrl = "http://www.mikz.com/picto/BarNightclubs.png" };
        private readonly Category category2 = new Category { Id = 3, Title = "Books", ImageUrl = "http://www.mikz.com/picto/Books.png" };
        private readonly Category category3 = new Category { Id = 4, Title = "Culture", ImageUrl = "http://www.mikz.com/picto/Culture.png" };
        private readonly Category category4 = new Category { Id = 5, Title = "Deals", ImageUrl = "http://www.mikz.com/picto/Deals.png" };

        private readonly IEnumerable<Brand> brands = new[]
        {
            new Brand{CategoryId = 3,Id = 1,Title = "Kulturbolaget",ImageUrl = "http://www.wkrb13.com/logos/constellation-brands-inc-logo.jpg"},
            new Brand {CategoryId = 3, Id = 2, Title = "O'Learys", ImageUrl = "http://t1.gstatic.com/images?q=tbn:ANd9GcQ7husckeK3gpzDu8rK6AbO0YBRE0ErR28ZEYSszg5321MlMaSzIw"},
            new Brand {CategoryId = 3, Id = 3, Title = "Big Slap", ImageUrl = "http://images.sodahead.com/polls/003234875/2519909524_MacDonalds_Logo_xlarge.png"},
            new Brand {CategoryId = 3, Id = 4, Title = "Babel", ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Adidas_Logo.svg/562px-Adidas_Logo.svg.png"},
            new Brand {CategoryId = 2, Id = 5, Title = "CDON", ImageUrl = "http://wpcontent.answcdn.com/wikipedia/commons/thumb/9/94/Old_Nike_logo.jpg/200px-Old_Nike_logo.jpg"},
            new Brand {CategoryId = 2, Id = 6, Title = "Bokia", ImageUrl = "http://www.africatopsports.com/wp-content/uploads/2013/08/psg.jpg"}
        };

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "AngularStart.Models.DataContext";
        }

        protected override void Seed(DataContext context)
        {
            this.CreateCategories(context);
            this.CreateBrands(context);
        }

        private void CreateCategories(DataContext context)
        {
            context.Categories.AddOrUpdate(x => x.Title, category);
            context.Categories.AddOrUpdate(x => x.Title, category1);
            context.Categories.AddOrUpdate(x => x.Title, category2);
            context.Categories.AddOrUpdate(x => x.Title, category3);
            context.Categories.AddOrUpdate(x => x.Title, category4);

            context.SaveChanges();
        }

        private void CreateBrands(DataContext context)
        {
            foreach (var brand in brands)
            {
                context.Brands.AddOrUpdate(x => x.Title, brand);
            }
        }
    }
}
