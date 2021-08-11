using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayer.Core.Repositories;
using UdemyNLayer.Core.Entitiy_Model_;

namespace UdemyNLayer.Core.Repositories
{
    public interface ICategoryRepository:IRepository<Category>
    {
        Task<Category> GetWithProductIdAsync(int categoryId);

    }
}
