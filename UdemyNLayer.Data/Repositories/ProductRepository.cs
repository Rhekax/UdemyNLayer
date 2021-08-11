using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayer.Core.Entitiy_Model_;
using UdemyNLayer.Core.Repositories;

namespace UdemyNLayer.Data.Repositories
{
    public class ProductRepository : Repository<Products>, IProductRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }

        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Products> GetWithCategoryIdAsync(int productId)
        {
            return await  _appDbContext.Products.Include(x => x.Category).SingleOrDefaultAsync(x => x.Id == productId);
        }
    }
}
