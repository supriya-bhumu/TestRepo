using MarsQAProfile.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowProject1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpecFlowProject1.Pages
{
    public  class Login:Driver
    {
        public static string Url = "http://localhost:5000";
        //Method to login into QA Mars Profile page
        public  void login()
        {
            
            driver.Navigate().GoToUrl(Url);

            Thread.Sleep(500);
            IWebElement SignInButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            SignInButton.Click();
          
           
                // identify username textbox and enter valid username
                IWebElement usernameInput = driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]"));
                usernameInput.SendKeys("supriyabhumu@gmail.com");
          
            
            // identify password textbox and enter valid password
            IWebElement passwordInput = driver.FindElement(By.XPath("//INPUT[@type='password']"));
            passwordInput.SendKeys("Password40#");

            // identify login button and click on it
            IWebElement loginButton = driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']"));
            loginButton.Click();
            
            
        }
    }
}
