using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayer.Core.Entitiy_Model_;

namespace UdemyNLayer.Core.Service
{
    public interface ICategoryService:IService<Category>
    {
        Task<Category> GetWithProductIdAsync(int categoryId);
    }
}
