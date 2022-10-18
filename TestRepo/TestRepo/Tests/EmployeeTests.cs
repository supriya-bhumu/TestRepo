using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRepo.Pages;
using TestRepo.Utilities;

namespace TestRepo.Tests
{
    [TestFixture]
    [Parallelizable]
    public class EmployeeTests : CommonDriver
    {
        Homepage hp = new Homepage();
        Employee emp = new Employee();

        [Test,Order(1)]
        public void CreateEmployeeTest()
        {
            hp.GoToEmployeePage(driver);

            emp.Create(driver);
        }

        [Test, Order(2)]
        public void EditEmployeeTest()
        {
            hp.GoToEmployeePage(driver);

            emp.Edit(driver);
        }

        [Test, Order(3)]
        public void DeleteEmployeeTest()
        {
            hp.GoToEmployeePage(driver);

            emp.Delete(driver);
        }
    }
}