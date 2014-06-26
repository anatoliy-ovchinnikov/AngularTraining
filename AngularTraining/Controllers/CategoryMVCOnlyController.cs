namespace AngularStart.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using Models;

    public class CategoryMVCOnlyController : Controller
    {
        private readonly DataContext context = new DataContext();
        //
        // GET: /CategoryMVCOnly/

        public ActionResult Index(int? id = 1)
        {
            try
            {
                var category = context.Categories.Find(id);
                var model = new CategoryViewModel
                {
                    Categories = context.Categories,
                    SelectedCategoryId = category.Id
                };
                return View(model);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        public ActionResult BrandsPartial(int? id = 1)
        {
            try
            {
                var category = context.Categories.Find(id);

                var modelToView = new BrandViewModel
                {
                    Brands = id != 1 ? context.Brands.Where(x => x.CategoryId == id) : context.Brands,
                    SelectedCategoryId = category.Id
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
            try
            {
                var modelToView = new SingleBrandViewModel
                {
                    CurrBrand = context.Brands.Find(id),
                    SelectedCategoryId = redirect
                };
                return View(modelToView);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        //
        // POST: /CategoryMVCOnly/Edit/5

        [HttpPost]
        public ActionResult Edit(SingleBrandViewModel model, int redirect)
        {
            try
            {
                var brand = context.Brands.Find(model.CurrBrand.Id);
                brand.Title = model.CurrBrand.Title;

                context.SaveChanges();

                return RedirectToAction("Index", new { id = redirect });
            }
            catch
            {
                return View("Error");
            }
        }
    }
}