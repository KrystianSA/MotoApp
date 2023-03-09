using Microsoft.EntityFrameworkCore;
using MotoApp.Entities;

namespace MotoApp.Repositories
{
    public class SqlRepository
    {
        public readonly DbSet<Employee> dbSet;
        public readonly DbContext dbContext;

        public SqlRepository(DbContext DbContext)
        {
            dbContext = DbContext;
            dbSet = dbContext.Set<Employee>();
        }
        public Employee? GetByID(int id)
        {
            return dbSet.Find(id);
        }
        public void Add(Employee item)
        {
            dbSet.Add(item);
        }
        public void Remove(Employee item)
        {
            dbSet.Remove(item);

        }
        public void Save()
        {
            dbContext.SaveChanges();
        }
    }
}
