using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayer.Core.Entitiy_Model_;
using UdemyNLayer.Core.Repositories;
using UdemyNLayer.Core.Service;
using UdemyNLayer.Core.UnitofWorks;

namespace UdemyNLayer.Service.Services
{
    public class ProductService : Service<Products>, IProductService
    {
        public ProductService(IUnitofwork unitofwork, IRepository<Products> repository) : base(unitofwork, repository)
        {
        }

        public async Task<Products> GetWithCategoryIdAsync(int productId)
        {
            return await _unitOfWork.Products.GetWithCategoryIdAsync(productId);
        }
    }
}
        