using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Infrastructure.Models.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();

        T Insert(T model);
    }
}
