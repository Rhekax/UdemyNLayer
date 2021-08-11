using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayer.Core.Repositories;

namespace UdemyNLayer.Core.UnitofWorks
{
    public interface IUnitofwork
    {
        IProductRepository Products { get; }

        ICategoryRepository Category { get; }
        Task CommitAsync();

        void Commit();
    }
}
