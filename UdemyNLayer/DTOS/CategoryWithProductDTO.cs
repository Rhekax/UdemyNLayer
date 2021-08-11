using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyNLayer.Core.Entitiy_Model_;

namespace UdemyNLayer.DTOS
{
    public class CategoryWithProductDTO:CategoryDTO
    {
        public ICollection <ProductDTO> Products{ get; set; }
    }
}
