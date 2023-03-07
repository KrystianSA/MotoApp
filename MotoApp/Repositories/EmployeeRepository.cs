
namespace MotoApp.Repositories
{
    using MotoApp.Entities;
    public class EmployeeRepository
    {
        private readonly List<Employee> employees = new();
        public void Add(Employee employee)
        {
            employee.Id = employees.Count + 1;
            employees.Add(employee);
        }
        public void Save()
        {
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
        public Employee GetByID(int id) 
        {
            return employees.Single(item=>item.Id == id);
        }
    }
}