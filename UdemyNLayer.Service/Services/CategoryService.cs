using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayer.Core.Entitiy_Model_;
using UdemyNLayer.Core.Repositories;
using UdemyNLayer.Core.Service;
using UdemyNLayer.Core.UnitofWorks;
using UdemyNLayer.Data.Repositories;

namespace UdemyNLayer.Service.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        public CategoryService(IUnitofwork unitofwork, IRepository<Category> repository) : base(unitofwork, repository)
        {
        }

        public async Task<Category> GetWithProductIdAsync(int categoryId)
        {
            return await _unitOfWork.Category.GetWithProductIdAsync(categoryId);
        }
    }
}
