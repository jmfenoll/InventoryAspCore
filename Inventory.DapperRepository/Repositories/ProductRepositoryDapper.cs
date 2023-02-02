using Inventory.Infrastructure.Models;
using Inventory.Infrastructure.Models.Interfaces;

namespace Inventory.Infrastructure.DapperRepository
{
    public class ProductRepositoryDapper : IRepository<Product>
    {
        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }


        public Product Insert(Product model)
        {
            throw new NotImplementedException();
        }


    }
}
