using RepositoryComponets.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RepositoryComponets.Repository
{
    public class EmployeeRepository: IEmployeeRepository
    {

        private readonly string? apiUrlall = Environment.GetEnvironmentVariable("API_URL");
        private readonly string? apiUrlById = Environment.GetEnvironmentVariable("API_URL_BY_ID");
        public async Task<Employee> GetEmployees()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrlall);

                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();

                        var outPut = JsonSerializer.Deserialize<Employee>(result.ToString());

                        return outPut;
                    }
                    else
                    {
                        Console.WriteLine("Somenthing Went Wrong , statusCode: " + response.StatusCode);
                        return new Employee();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Somenthing Went Wrong:  " + ex.Message);
                    return new Employee();
                }
            }
        }

        public async Task<IndividualEmployee> GetEmployeesById(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync($"{apiUrlById}/{id}");

                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();

                        var outPut = JsonSerializer.Deserialize<IndividualEmployee>(result.ToString());

                        return outPut;
                    }
                    else
                    {
                        Console.WriteLine("Somenthing Went Wrong , statusCode: " + response.StatusCode);
                        return new IndividualEmployee();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Somenthing Went Wrong:  " + ex.Message);
                    return new IndividualEmployee(); ;
                }
            }
        }
    }
}
