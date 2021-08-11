using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UdemyNLayer.Core.Entitiy_Model_;

namespace UdemyNLayer.Data.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Products>
    {
        private readonly int[] _Ids;

        public ProductSeed(int[] Ids)
        {
            _Ids = Ids;
        }

        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.HasData(
                new Products { Id = 1, Name = "Pilot Kalem", Price = 12.50m, Stock = 100, CategoryId = _Ids[0] },
                new Products { Id = 2, Name = "Kur;un Kalem", Price = 50.50m, Stock = 200, CategoryId = _Ids[0] },
                new Products { Id = 3, Name = "Tukenmez Kalem", Price = 500m, Stock = 400, CategoryId = _Ids[0] },
                new Products { Id = 4, Name = "Kucuk boy defter", Price = 20.50m, Stock = 300, CategoryId = _Ids[1] },
                new Products { Id = 5, Name = "orta boy defter", Price = 30.50m, Stock = 300, CategoryId = _Ids[1] },
                new Products { Id = 6, Name = "buyuk boy defter", Price = 40.50m, Stock = 300, CategoryId = _Ids[1] }


                );
        }
    }
}
