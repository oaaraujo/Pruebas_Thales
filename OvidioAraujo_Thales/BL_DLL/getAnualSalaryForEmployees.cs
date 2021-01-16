using DataAccess;
using EntityLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_DLL
{
    public class getAnualSalaryForEmployees
    {
        public async Task<List<Employee>> CalculateAnualSalary()
        {
            List<Employee> ResultList = new List<Employee>();
            try
            {

                EmployeeDta DataEmployees = new EmployeeDta();
                GetDataEmployee ObjData = new GetDataEmployee();

                DataEmployees = await ObjData.GetEmployees();


                foreach (var dta in DataEmployees.Data)
                {
                    ResultList.Add(new Employee
                    {
                        id = dta.id,
                        employee_name = dta.employee_name,
                        employee_salary = dta.employee_salary,
                        employee_age = dta.employee_age,
                        profile_image = dta.profile_image,
                        anual_salary = (decimal.Parse(dta.employee_salary) * 12).ToString()
                    });
                }

                return ResultList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public async Task<List<Employee>> CalculateAnualSalaryById(string id)
        {
            try
            {
                List<Employee> ResultList = new List<Employee>();
                EmployeeDta DataEmployee = new EmployeeDta();
                GetDataEmployee ObjData = new GetDataEmployee();

                DataEmployee = await ObjData.GetEmployeeById(id);

                foreach (var dta in DataEmployee.Data)
                {
                    ResultList.Add(new Employee
                    {
                        id = dta.id,
                        employee_name = dta.employee_name,
                        employee_salary = dta.employee_salary,
                        employee_age = dta.employee_age,
                        profile_image = dta.profile_image,
                        anual_salary = (decimal.Parse(dta.employee_salary) * 12).ToString()
                    });
                }

                return ResultList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            

        }

    }
}
