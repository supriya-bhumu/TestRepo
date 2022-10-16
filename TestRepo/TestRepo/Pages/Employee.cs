using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace TestRepo.Pages
{
  public class Employee
    {
        public void Create(IWebDriver driver)
        {
            IWebElement createButton = driver.FindElement(By.XPath("/html/body/div[4]/p/a"));
            createButton.Click();
            IWebElement name = driver.FindElement(By.Id("Name"));
            name.SendKeys("Suppu");
            IWebElement username= driver.FindElement(By.Id("Username"));
            username.SendKeys("November11");
            IWebElement editButton = driver.FindElement(By.Id("EditContactButton"));
            editButton.Click();
            Thread.Sleep(1000);
            //switching to iframe window
            driver.SwitchTo().Frame(0);

            IWebElement firstname = driver.FindElement(By.Id("FirstName"));
            firstname.SendKeys("Mary Supriya");
            IWebElement lastname = driver.FindElement(By.Id("LastName"));
            lastname.SendKeys("Bhumu");
            IWebElement preferedname = driver.FindElement(By.Id("PreferedName"));
             preferedname.SendKeys("Supriya");
            IWebElement phone = driver.FindElement(By.Id("Phone"));
            phone.SendKeys("1234567890");
            IWebElement mobile = driver.FindElement(By.Id("Mobile"));
            mobile.SendKeys("0987654321");
            IWebElement Email = driver.FindElement(By.Id("email"));
            Email.SendKeys("sup@gmail.com");
            IWebElement fax = driver.FindElement(By.Id("Fax"));
            fax.SendKeys("1234");
            IWebElement street = driver.FindElement(By.Id("Street"));
            street.SendKeys("52,GilmourSt");

            IWebElement city = driver.FindElement(By.Id("City"));
            city.SendKeys("Brisbane");
            IWebElement postcode = driver.FindElement(By.Id("Postcode"));
            postcode.SendKeys("4509");
            IWebElement country = driver.FindElement(By.Id("Country"));
            country.SendKeys("Australia");
            IWebElement submitbutton = driver.FindElement(By.Id("submitButton"));
            submitbutton.Click();
            Thread.Sleep(5000);
            //Switching back to original window
            driver.SwitchTo().DefaultContent();

            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("November@11");
            IWebElement Retypepassword = driver.FindElement(By.Id("RetypePassword"));
            Retypepassword.SendKeys("November@11");
            IWebElement checkbox = driver.FindElement(By.Id("IsAdmin"));
            checkbox.Click();
            IWebElement vehicle = driver.FindElement(By.XPath("/html/body/div[4]/form/div/div[7]/div/span[1]/span/input"));
            vehicle.SendKeys("Car");
            IWebElement groups= driver.FindElement(By.XPath("/ html / body / div[4] / form / div / div[8] / div / div / div[1]"));
            groups.Click();
            IWebElement ausgroup = driver.FindElement(By.XPath("//*[@id=\"groupList_listbox\"]/li[23]"));
            ausgroup.Click();
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
           // driver.SwitchTo().Alert().Accept();
            IWebElement gobacktolist = driver.FindElement(By.XPath("/ html / body / div[4] / div / a"));
            gobacktolist.Click();
            Thread.Sleep(2000);
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("/ html / body / div[4] / div / div / div[4] / a[4] / span"));
            goToLastPageButton.Click();
            Thread.Sleep(2000);
            IWebElement lastCode = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(lastCode.Text == "Suppu", "Time record hasn't been created.");

        }

        public void Edit(IWebDriver driver)
        {
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(1000);
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
            editButton.Click();
            IWebElement name = driver.FindElement(By.Id("Name"));
            name.Clear();
            name.SendKeys("SupriyaT");
            IWebElement username = driver.FindElement(By.Id("Username"));
            username.Clear();
            username.SendKeys("October11");
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            // driver.SwitchTo().Alert().Accept();
            IWebElement gobacktolist = driver.FindElement(By.XPath("/ html / body / div[4] / div / a"));
            gobacktolist.Click();
            Thread.Sleep(2000);
            IWebElement goToLastPageButton1 = driver.FindElement(By.XPath("/ html / body / div[4] / div / div / div[4] / a[4] / span"));
            goToLastPageButton1.Click();
            Thread.Sleep(2000);
            IWebElement lastCode = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement editedUsername = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[2]"));
            
            Assert.That(lastCode.Text == "SupriyaT", "Edited code and expected code do not match.");
            Assert.That(editedUsername.Text == "October11", "Edited username and expected description do not match.");
           

        }

        public void Delete(IWebDriver driver)
        {    //going to last page
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(1000);
          
            IWebElement lastRecord = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
            deleteButton.Click();
            Thread.Sleep(500);
            driver.SwitchTo().Alert().Accept();
            //IWebElement goToLastPageButton1 = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(2000);
            IWebElement newLastRecord = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(newLastRecord != lastRecord, "Time record hasn't been deleted.");

        }


    }
}
