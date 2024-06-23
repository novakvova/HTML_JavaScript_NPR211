using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class CategoryEntity
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(255)]
        public required string Name { get; set; }
        [StringLength(4000)]
        public string? Description { get; set; }
        [StringLength(256)]
        public string? ImagePath { get; set; }
    }
}
