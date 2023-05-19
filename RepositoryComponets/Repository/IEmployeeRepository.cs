using RepositoryComponets.DTO;

namespace RepositoryComponets
{
    /// <summary>
    /// Employess's interface repository layer
    /// </summary>
    /// 
    public interface IEmployeeRepository
    {
        // Methods

        /// <summary>
        /// Get Employees information
        /// </summary>
        /// <param name="id">Emplyee Id</param>        
        public Task<IndividualEmployee> GetEmployeesById(int id);
        public Task<Employee> GetEmployees();

    }

}