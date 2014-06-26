namespace AngularStart.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The class represents the brand.
    /// </summary>
    public class Brand : Entity
    {
        /// <summary>
        /// Gets or sets the category identifier.
        /// </summary>
        public int CategoryId { get; set; }
    }
}