namespace AngularStart.Models
{
    using System.Collections.Generic;

    public class CategoryViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
        public int SelectedCategoryId { get; set; }
    }
}