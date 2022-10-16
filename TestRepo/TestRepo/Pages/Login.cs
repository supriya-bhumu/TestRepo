using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepo.Pages
{
    public  class Login
    {
        
        public void login(IWebDriver driver)
        {
            
            // navigate to TurnUp portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();
            Thread.Sleep(500);

            // identify username textbox and enter valid username
            IWebElement usernameInput = driver.FindElement(By.Id("UserName"));
            usernameInput.SendKeys("hari");

            // identify password textbox and enter valid password
            IWebElement passwordInput = driver.FindElement(By.Id("Password"));
            passwordInput.SendKeys("123123");

            // identify login button and click on it
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();
            Thread.Sleep(2000);
        }
    }
}
