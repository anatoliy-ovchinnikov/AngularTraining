namespace AngularStart.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The class represents the entity.
    /// </summary>
    public class Entity
    {
        /// <summary>
        /// Gets or sets the identifier of the entity.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the image URL of the entity.
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the title of the entity.
        /// </summary>
        public string Title { get; set; }
    }
}