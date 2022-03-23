namespace CoffeeAppGeneric.Repositories
{
    /// <summary>
    /// inheritance from Generic class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericRepositoryWithRemove<T>:GenericRepository<T>
    {
        public void Remove(T item)
        {
            _items.Remove(item);
        }
    }
}
