using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UdemyNLayer.Core.Entitiy_Model_;

namespace UdemyNLayer.Data.Seeds
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        private readonly int[] _Ids;


        public CategorySeed(int[] Ids)
        {
            _Ids = Ids;
        }


        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = _Ids[0], Name = "Kalemler" },
                 new Category { Id = _Ids[1], Name = "Defterler" }
                 );

        }
    }
}
