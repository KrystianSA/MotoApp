using MotoApp.Repositories;
using MotoApp.Entities;
using MotoApp.Data;
/*
var employeeRepository = new GenericRepository<Employee,int>();
employeeRepository.Add(new Employee { Firstname = "Adam" });
employeeRepository.Add(new Employee { Firstname = "Krystian" });
employeeRepository.Add(new Employee { Firstname = "Pawel" });
employeeRepository.Save();*/

var sqlRepository = new SqlRepository(new MotoAppDbContext());
sqlRepository.Add(new Employee { Firstname = "Adam" });
sqlRepository.Add(new Employee { Firstname = "Krystian" });
sqlRepository.Add(new Employee { Firstname = "Pawel" });
sqlRepository.Save(); 
var emp = sqlRepository.GetByID(1);
Console.WriteLine(emp.ToString());