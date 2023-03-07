using MotoApp.Repositories;
using MotoApp.Entities;

var employeeRepository = new GenericRepository<Employee>();
employeeRepository.Add(new Employee { Firstname = "Adam" });
employeeRepository.Add(new Employee { Firstname = "Krystian" });
employeeRepository.Add(new Employee { Firstname = "Pawel" });
employeeRepository.Save();