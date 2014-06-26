namespace AngularStart.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;
    using Models;

    public class CategoryController : ApiController
    {
        private Repository db = InitializeRepository.GetRepository();
        // GET api/base
        public IEnumerable<Category> Get()
        {
            if (db==null)
            {
                throw new ArgumentNullException("Repository");
            }
            return db.categories;
        }

        public Category Get(int id, int? limit = null, int offset = 0)
        {
            if (db == null)
            {
                throw new ArgumentNullException("Repository");
            }
            var categ = db.categories.Single(cat => cat.Id == id);
            return categ;
        }
    }
}
