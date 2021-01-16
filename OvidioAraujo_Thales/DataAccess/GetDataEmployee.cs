using EntityLibrary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class GetDataEmployee
    {
        public async Task<EmployeeDta> GetEmployees()
        {
            EmployeeDta employeesList = new EmployeeDta();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://dummy.restapiexample.com/api/v1/employees"))
                {
                    if(response.IsSuccessStatusCode)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        employeesList = JsonConvert.DeserializeObject<EmployeeDta>(apiResponse);
                        return employeesList;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                    
                }
            }
           
        }

        public async Task<EmployeeDta> GetEmployeeById(string id)
        {
            EmployeeDta employeesList = new EmployeeDta();
            string Url = "http://dummy.restapiexample.com/api/v1/employee/" + id;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(Url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        employeesList = JsonConvert.DeserializeObject<EmployeeDta>(apiResponse);
                        return employeesList;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }

                }
            }
        }
    }
}
