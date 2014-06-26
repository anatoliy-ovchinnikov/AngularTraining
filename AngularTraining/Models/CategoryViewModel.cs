namespace AngularStart.Models
{
    using System.Collections.Generic;

    public class CategoryViewModel
    {
        public List<Category> Categories { get; set; }
        public int SelectedCategoryId { get; set; }
    }
}