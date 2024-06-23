using Microsoft.AspNetCore.Http;

namespace Core.DTO
{
    public class EditCategoryDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public IFormFile? ImageFile { get; set; }
    }
}
