namespace AngularStart.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Web.Http;
    using Models;

    public class BrandController : ApiController
    {
        private readonly DataContext context = new DataContext();

        // GET api/brand
        public IEnumerable<Brand> Get()
        {
            if (this.context == null)
                throw new ArgumentNullException("context");

            return this.context.Brands;
        }

        // GET api/brand/5
        public Brand Get(int id)
        {
            return this.context.Brands.Find(id);
        }

        // PUT api/brand/5
        public void Put(int id, Brand editBrand)
        {
            if (editBrand == null)
                throw new ArgumentNullException("editBrand");

            var brand = this.context.Brands.Find(id);

            brand.Title = editBrand.Title;

            this.context.SaveChanges();
        }

    }
}