namespace AngularStart.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using Models;

    public class CategoryMVCOnlyController : Controller
    {
        private Repository db = InitializeRepository.GetRepository();
        //
        // GET: /CategoryMVCOnly/

        public ActionResult Index(int? id = 0)
        {
            try
            {
                Category activeCategory = db.categories.Single(cat => cat.Id == id);
                var modelToView = new CategoryViewModel
                {
                    Categories = db.categories,
                    SelectedCategoryId = activeCategory == null ? 0 : activeCategory.Id
                };
                return View(modelToView);
            }
            catch (Exception)
            {
                return View("Error");
            }

        }

        public ActionResult BrandsPartial(int? id = 0)
        {
            try
            {
                Category currCategory = db.categories.Single(cat => cat.Id == id);
                var modelToView = new BrandViewModel
                {
                    Brands = currCategory.Brands.ToList(),
                    SelectedCategoryId = (int)id
                };
                return PartialView(modelToView);
            }
            catch (Exception)
            {
                return View("Error");
            }

        }

        //
        // GET: /CategoryMVCOnly/Edit/5

        public ActionResult Edit(int id, int redirect)
        {
            Category curCategory = db.categories[0];
            if (curCategory != null)
            {
                var modelToView = new SingleBrandViewModel
                {
                    CurrBrand = curCategory.Brands.Single(br => br.Id == id),
                    SelectedCategoryId = redirect
                };
                return View(modelToView);
            }
            return View("Error");
        }

        //
        // POST: /CategoryMVCOnly/Edit/5

        [HttpPost]
        public ActionResult Edit(SingleBrandViewModel model, int redirect)
        {
            try
            {
                foreach (var category in db.categories)
                {
                    if (category.Brands != null)
                    {
                        foreach (var brand in category.Brands)
                        {
                            brand.Title = brand.Id == model.CurrBrand.Id ? model.CurrBrand.Title : brand.Title;
                        }
                    }
                }

                return RedirectToAction("Index", new { id = redirect });
            }
            catch
            {
                return View("Error");
            }
        }
    }
}
