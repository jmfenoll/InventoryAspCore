using Infrastructure.Interfaces;
using Inventory.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Infrastructure.Dapper
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
