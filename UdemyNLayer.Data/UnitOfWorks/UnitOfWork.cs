using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayer.Core.Repositories;
using UdemyNLayer.Core.UnitofWorks;
using UdemyNLayer.Data.Repositories;

namespace UdemyNLayer.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitofwork
    {

        private readonly AppDbContext _context;

        private IProductRepository _productRepository;
        private ICategoryRepository _categoryRepository;


        public IProductRepository Products => _productRepository = _productRepository ?? new ProductRepository(_context);

        public ICategoryRepository Category => _categoryRepository = _categoryRepository ?? new CategoryRepository(_context);


        public UnitOfWork(AppDbContext appDbContext)
        {
            _context = appDbContext;

        }
        public void Commit()
        {
            _context.SaveChanges();


        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
