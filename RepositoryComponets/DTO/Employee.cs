using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryComponets.DTO
{   
    public class EmployeeData
    {
        public int id { get; set; }
        public string employee_name { get; set; }
        public int employee_salary { get; set; }
        public int employee_anual_salary { get; set; }
        public int employee_age { get; set; }
        public string profile_image { get; set; }
    }

    public class Employee
    {
        public string status { get; set; }
        public List<EmployeeData> data { get; set; }
        public string message { get; set; }
    }

    public class IndividualEmployee 
    {
        public string status { get; set; }
        public EmployeeData data { get; set; }
        public string message { get; set; }
    }

   
}
