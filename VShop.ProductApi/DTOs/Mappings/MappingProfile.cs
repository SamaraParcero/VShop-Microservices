using AutoMapper;
using VShop.ProductApi.Models;

namespace VShop.ProductApi.DTOs.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>()
            .ForMember(dest => dest.CategoryName,
            opt => opt.MapFrom(src => src.Category.Name))
            .ReverseMap()
            .ForMember(dest => dest.Category, opt => opt.Ignore());
        }

    }
}
