using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeAppGeneric.Entities;

namespace CoffeeAppGeneric.Repositories
{
    public class GenericRepository<T>
    {
        protected readonly List<T> _items;

        public GenericRepository()
        {
            _items = new List<T>();
        }

        public void Add(T item)
        {
            _items.Add(item);
        }

        public void Save()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
