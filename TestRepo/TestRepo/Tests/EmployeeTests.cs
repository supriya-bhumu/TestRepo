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
       
        Login lg = new Login();
        Homepage hp = new Homepage();
        TM_Page page = new TM_Page();
        Employee emp = new Employee();



        
        [SetUp]
        public void LoginActions()
        {
            // open chrome browser

            driver = new ChromeDriver();

            // Login page object initialization and definition

            lg.login(driver);
            hp.GoToEmployeePage(driver);
        }

        [Test,Order(1)]
        public void CreateEmployeeTest()
        {

            emp.Create(driver);
        }

        [Test, Order(2)]
        public void EditEmployeeTest()
        {

            emp.Edit(driver);
        }

        [Test, Order(3)]
        public void DeleteEmployeeTest()
        {

            emp.Delete(driver);
        }

        [TearDown]
        public void ClosingSteps()
        {
            driver.Quit();
        }
    }
}