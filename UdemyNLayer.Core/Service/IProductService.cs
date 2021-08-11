using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayer.Core.Entitiy_Model_;

namespace UdemyNLayer.Core.Service
{
    public interface IProductService:IService<Products>
    {
        Task<Products> GetWithCategoryIdAsync(int productId);
    }
}
