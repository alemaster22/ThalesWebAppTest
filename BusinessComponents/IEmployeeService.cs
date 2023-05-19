using RepositoryComponets.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessComponents
{
    // Methods

    /// <summary>
    /// Get Employees information
    /// </summary>
    /// <param name="id">Emplyee Id</param> 
    public interface IEmployeeService
    {
        public Task<Employee> GetEmployees();
        public Task<IndividualEmployee> GetEmployeesById(int id);
    }
}
