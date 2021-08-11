using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayer.Core.Entitiy_Model_;

namespace UdemyNLayer.Core.Repositories
{
    public interface IProductRepository : IRepository<Products>
    {
        Task<Products> GetWithCategoryIdAsync(int productId);

    }
}
