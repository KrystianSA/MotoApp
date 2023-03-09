
namespace MotoApp.Repositories
{
    using MotoApp.Entities;
    public class GenericRepository<T>
        where T : class, IEntity, new()
    {
        private readonly List<T> items = new();
        public T GetByID(int id)
        {

            return items.Single(item => item.Id == id);
        }
        public void Add(T item)
        {
            item.Id = items.Count + 1;
            items.Add(item);
        }
        public void Remove(T item)
        {
            items.Remove(item);
        }
        public void Save()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}