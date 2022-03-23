using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeAppGeneric.Entities;

namespace CoffeeAppGeneric.Repositories
{
    public interface ISqlReadRepository<out T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
