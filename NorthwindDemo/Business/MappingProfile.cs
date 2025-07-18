using AutoMapper;
using Entities;

namespace Business;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<ProductDto, Product>();
        CreateMap<Product, ProductDto>();
    }
}