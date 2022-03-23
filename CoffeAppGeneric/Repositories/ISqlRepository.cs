using System.Collections;
using System.Collections.Generic;
using CoffeeAppGeneric.Entities;

namespace CoffeeAppGeneric.Repositories
{
    public interface ISqlRepository<T>:ISqlReadRepository<T> where T : IEntityBase
    {
        void Add(T item);
        void Save();
        
        void Remove(T item);
    }
}