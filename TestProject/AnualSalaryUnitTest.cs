using RepositoryComponets.DTO;
using Xunit;

namespace TestProject
{
    public class AnualSalaryUnitTest
    {
        [Fact]
        public void Test1()
        {
            var service = new BusinessComponents.EmployeeService();

            IndividualEmployee testEmploy = new IndividualEmployee();

            EmployeeData employData = new EmployeeData();

            testEmploy.data = employData;
            employData.employee_salary = 1000;

            service.setAnualSalary(testEmploy);

            var anual_salary = testEmploy.data.employee_anual_salary;

            Assert.Equal(12000, anual_salary);
                
        }
    }
}