namespace AngularStart.Models
{
    /// <summary>
    /// The class represents the brand.
    /// </summary>
    public class Brand : Entity
    {
        /// <summary>
        /// Gets or sets the category identifier.
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the category of the specified brand.
        /// </summary>
        public virtual Category Category { get; set; }
    }
}