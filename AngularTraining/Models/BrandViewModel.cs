namespace AngularStart.Models
{
    using System.Collections.Generic;

    public class BrandViewModel
    {
        public List<Brand> Brands { get; set; }
        public int SelectedCategoryId { get; set; }
    }
}