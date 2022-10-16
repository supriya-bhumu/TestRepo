using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepo.Pages
{
   public class Homepage
    {
        
        public void GoToTMPage(IWebDriver driver)
        {
           
            IWebElement adminDropDown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminDropDown.Click();
            Thread.Sleep(500);
            IWebElement TM = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul/ li[5] / ul / li[3] / a"));
            TM.Click();
            Thread.Sleep(500);
        }
        public void GoToEmployeePage(IWebDriver driver)
        {
            IWebElement adminDropDown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminDropDown.Click();
            Thread.Sleep(500);
            IWebElement EMP = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            EMP.Click();
            Thread.Sleep(500);
        }
    }
}
