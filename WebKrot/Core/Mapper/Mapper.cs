using Core.DTO;
using Core.Entities;

namespace Core.Mapper
{
    public class Mapper : AutoMapper.Profile
    {
        public Mapper()
        {
            CreateMap<CategoryDTO, CategoryEntity>().ReverseMap();
            CreateMap<CreateCategoryDTO, CategoryEntity>().ReverseMap();
            CreateMap<EditCategoryDTO, CategoryEntity>().ReverseMap();
        }
    }
}
