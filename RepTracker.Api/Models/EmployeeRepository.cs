using System.Collections.Generic;
using System.Linq;
using RepTracker.Shared;

namespace RepTracker.Api.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _appDbContext;

        public EmployeeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _appDbContext.Employees;
        }

        public Employee GetEmployeeById(int employeeId)
        {
            return _appDbContext.Employees.FirstOrDefault(c => c.EmployeeId == employeeId);
        }

        public Employee AddEmployee(Employee employee)
        {
            var addedEntity = _appDbContext.Employees.Add(employee);
            _appDbContext.SaveChanges();
            return addedEntity.Entity;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            var foundEmployee = _appDbContext.Employees.FirstOrDefault(e => e.EmployeeId == employee.EmployeeId);

            if (foundEmployee != null)
            {
                foundEmployee.CountryId = employee.CountryId;
                foundEmployee.MaritalStatus = employee.MaritalStatus;
                foundEmployee.BirthDate = employee.BirthDate;
                foundEmployee.Email = employee.Email;
                foundEmployee.PhoneNumber = employee.PhoneNumber;
                foundEmployee.FirstName = employee.FirstName;
                foundEmployee.LastName = employee.LastName;
                foundEmployee.Gender = employee.Gender;
                foundEmployee.Comment = employee.Comment;
                foundEmployee.EndDate = employee.EndDate;
                foundEmployee.StartDate = employee.StartDate;

                _appDbContext.SaveChanges();

                return foundEmployee;
            }

            return null;
        }

        public void DeleteEmployee(int employeeId)
        {
            var foundEmployee = _appDbContext.Employees.FirstOrDefault(e => e.EmployeeId == employeeId);
            if (foundEmployee == null) return;

            _appDbContext.Employees.Remove(foundEmployee);
            _appDbContext.SaveChanges();
        }
    }
}
