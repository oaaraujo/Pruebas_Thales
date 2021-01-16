using BL_DLL;
using EntityLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OvidioAraujo_Thales.Models
{
    public class VM_Employees:Employee
    {
        public List<Employee> ListEmployees { get; set; }
    }
}