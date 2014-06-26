namespace AngularStart.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;
    using Models;

    public class CategoryController : ApiController
    {
        private readonly DataContext context = new DataContext();

        // GET api/base
        public IEnumerable<Category> Get()
        {
            if (this.context == null)
                throw new ArgumentNullException("context");

            return this.context.Categories;
        }

        public Category Get(int id)
        {
            if (this.context == null)
                throw new ArgumentNullException("context");

            var category = this.context.Categories.Find(id);

            category.Brands = id != 1 ? this.context.Brands.Where(x => x.CategoryId == id).ToList() : this.context.Brands.ToList();

            return category;
        }
    }
}