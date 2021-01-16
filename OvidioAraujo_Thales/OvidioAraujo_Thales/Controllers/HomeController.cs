using BL_DLL;
using OvidioAraujo_Thales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace OvidioAraujo_Thales.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            
            var model = new VM_Employees();
            var employee = new getAnualSalaryForEmployees();

            model.ListEmployees = await employee.CalculateAnualSalary();

            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> GetEmployees(FormCollection data, VM_Employees model)
        {
            var employee = new getAnualSalaryForEmployees();
            string Id = model.id;
         

            try
            {
                if (Id == "" || Id==null)
                {
                   model.ListEmployees = await employee.CalculateAnualSalary();
                }
                else
                {
                    model.ListEmployees = await employee.CalculateAnualSalaryById(Id);
                }
               

            }
            catch (Exception ex)
            {
                model.ListEmployees = new List<EntityLibrary.Employee>();
            }

            return PartialView("_Listfordata", model);
            
        }
    }
}