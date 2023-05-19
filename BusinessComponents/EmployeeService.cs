using RepositoryComponets;
using RepositoryComponets.DTO;
using System.Text.Json;

namespace BusinessComponents
{  
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public EmployeeService()
        {  
        }
        public async Task<Employee> GetEmployees() 
        {
           var listEmployee =  await _employeeRepository.GetEmployees();

            setAnualSalary(listEmployee);

            return listEmployee;
        }

        public async Task<IndividualEmployee> GetEmployeesById(int id) 
        {
            var listEmployee =  await _employeeRepository.GetEmployeesById(id);

            setAnualSalary(listEmployee);

            return listEmployee;
        }
        private void setAnualSalary(Employee emp)
        {
            foreach (var item in emp.data)
            {
                item.employee_anual_salary = item.employee_salary * 12;
            }            
        }
        public void setAnualSalary(IndividualEmployee emp) 
        {
            if (emp!= null) emp.data.employee_anual_salary  = emp.data.employee_salary * 12;
        }
            

    }
}