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

        public async Task<ActionResult> About()
        {
            ViewBag.Message = "Your application description page.";

            var client = new getAnualSalaryForEmployees();
             await client.CalculateAnualSalary();

            return View();
        }

        public async Task<ActionResult> Contact()
        {
            ViewBag.Message = "Your contact page.";

            var employee = new getAnualSalaryForEmployees();

            await employee.CalculateAnualSalaryById("6");

            return View();
        }
    }
}