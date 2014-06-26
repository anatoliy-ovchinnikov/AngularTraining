using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web;
using System.Web.Helpers;
using System.Web.Http;
using AngularStart.Models;

namespace AngularStart.Controllers
{
    public class BrandController : ApiController
    {
        private Repository db = InitializeRepository.GetRepository();

        // GET api/brand
        public IEnumerable<Brand> Get()
        {
            if (db.categories[0] != null)
            {
                return db.categories[0].Brands;
            }
            return null;
        }

        // GET api/brand/5
        public Brand Get(int id)
        {
            if (db.categories[0] != null)
            {
                var brands = db.categories[0].Brands;
                return brands.Single(brand => brand.Id == id);
            }
            return null;
        }

        // PUT api/brand/5
        public void Put(int id, Brand editBrand)
        {
            if (editBrand == null)
            {
                throw new ArgumentNullException("editBrand");
            }
            foreach (var category in db.categories)
            {
                if (category.Brands != null)
                {
                    category.Brands.ToList().ForEach(b => b.Title = b.Id == id ? editBrand.Title : b.Title);
                }
            }
        }

    }
}
