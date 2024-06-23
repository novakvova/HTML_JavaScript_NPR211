using Microsoft.AspNetCore.Http;

namespace Core.DTO
{
    public class CreateCategoryDTO
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public IFormFile? ImageFile { get; set; }
    }
}
