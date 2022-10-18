using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRepo.Pages;

namespace TestRepo.Utilities
{
   public class CommonDriver
    {
        public IWebDriver driver;

        Login lg = new Login();

        [OneTimeSetUp]
        public void LoginPage()
        {

            driver = new ChromeDriver();
            lg.login(driver);
        }

        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
