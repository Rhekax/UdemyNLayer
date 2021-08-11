using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyNLayer.Core.Entitiy_Model_;

namespace UdemyNLayer.DTOS
{
    public class ProductWithCategory:ProductDTO
    {
        public  CategoryDTO Category { get; set; }
    }
}
