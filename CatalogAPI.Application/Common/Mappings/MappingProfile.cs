using AutoMapper;
using CatalogAPI.Application.DTOs;
using CatalogAPI.Application.Products.Commands.CreateProduct;
using CatalogAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogAPI.Application.Common.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();

            CreateMap<ProductBrand, ProductBrandDto>().ReverseMap();
            CreateMap<ProductCategory, ProductCategoryDto>().ReverseMap();
            CreateMap<ProductType, ProductTypeDto>().ReverseMap();
            CreateMap<ProductImage, ProductImageDto>().ReverseMap();
            CreateMap<PSubDetailType, PSubDetailTypeDto>().ReverseMap();

            CreateMap<PSubDetail, PSubDetailDto>()
                .ForMember(dest => dest.TypeName, opt => opt.MapFrom(src => src.Type.Name))
                .ReverseMap();

            CreateMap<CreateProductCommand, Product>()
                .ForMember(dest => dest.ProductImage, opt => opt.Ignore()); 
        }
    }

}
