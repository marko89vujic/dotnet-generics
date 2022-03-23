using System.Collections;
using System.Collections.Generic;
using CoffeeAppGeneric.Entities;

namespace CoffeeAppGeneric.Repositories
{
    public interface ISqlRepository<T> where T : IEntityBase
    {
        IEnumerable<T> GetAll();
        void Add(T item);
        void Save();
        T GetById(int id);
        void Remove(T item);
    }
}