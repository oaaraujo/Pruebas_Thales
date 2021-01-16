using BL_DLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var GetAnualSalary = new getAnualSalaryForEmployees();
            var result = GetAnualSalary.CalculateAnualSalary();
            
           

        }

        [TestMethod]
        public void TestMethod2_T1()
        {
            var GetAnualSalary = new getAnualSalaryForEmployees();
            var result = GetAnualSalary.CalculateAnualSalaryById("");
            




        }

        [TestMethod]
        public void TestMethod2_T2()
        {
            var GetAnualSalary = new getAnualSalaryForEmployees();
            var result1 = GetAnualSalary.CalculateAnualSalaryById("A");
          




        }

        [TestMethod]
        public void TestMethod2_T3()
        {
            var GetAnualSalary = new getAnualSalaryForEmployees();
            var result2 = GetAnualSalary.CalculateAnualSalaryById("10");




        }

        [TestMethod]
        public void TestMethod2_T4()
        {
            var GetAnualSalary = new getAnualSalaryForEmployees();
            var result2 = GetAnualSalary.CalculateAnualSalaryById("-10");




        }
    }
}
