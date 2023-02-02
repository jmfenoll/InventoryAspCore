using Infrastructure.Interfaces;
using Inventory.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Infrastructure.Dapper
{
    public class ProductRepositorySql : IRepository<Product>
    {
        private readonly InventoryDbContext _context;


        public ProductRepositorySql(InventoryDbContext context)
        {
            _context = context;

        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product Insert(Product model)
        {
            var productInserted= _context.Products.Add(model);
            _context.SaveChanges();
            return productInserted.Entity;

        }
    }
}
