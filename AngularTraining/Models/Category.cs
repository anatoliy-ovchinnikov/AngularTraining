namespace AngularStart.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The class represents the category.
    /// </summary>
    public class Category : Entity
    {
        [NotMapped]
        public IList<Brand> Brands { get; set; }
    }
}