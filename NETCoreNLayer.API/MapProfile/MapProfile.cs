using AutoMapper;
using NETCoreNLayer.API.Dto;
using NETCoreNLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCoreNLayer.API.MapProfile
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<CategoryDto, Category>();
            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryProductsDto>();
            CreateMap<CategoryProductsDto, Category>();

            CreateMap<ProductDto, Product>();
            CreateMap<Product, ProductDto>();
            CreateMap<Product, ProductCategortyDto>();
            CreateMap<ProductCategortyDto, Product>();
        }
    }
}
