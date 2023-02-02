using Inventory.Infrastructure.Models;
using Inventory.Infrastructure.Models.Interfaces;

namespace Inventory.Infrastructure.EFSqlRepository.Context
{
    public class ProductRepository : IRepository<Product>
    {
        private readonly InventoryDbContext _context;


        public ProductRepository(InventoryDbContext context)
        {
            _context = context;

        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product Insert(Product model)
        {
            var productInserted = _context.Products.Add(model);
            _context.SaveChanges();
            return productInserted.Entity;

        }
    }
}
