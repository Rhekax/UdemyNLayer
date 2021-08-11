using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyNLayer.Core.Entitiy_Model_;
using UdemyNLayer.DTOS;

namespace UdemyNLayer.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Category, CategoryDTO>();
            CreateMap<CategoryDTO, Category>();

            CreateMap<Products, ProductDTO>();
            CreateMap<ProductDTO, Products>();

            CreateMap<Category, CategoryWithProductDTO>();
            CreateMap<CategoryWithProductDTO, Category>();

            CreateMap<Products, ProductWithCategory>();
            CreateMap<ProductWithCategory, Products>();

        }
    }
}
