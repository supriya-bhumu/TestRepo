using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepo.Pages
{
    public class TM_Page
    {


        public void create(IWebDriver driver)
        {

            IWebElement createNewButton = driver.FindElement(By.XPath("/html/body/div[4]/p/a"));
            createNewButton.Click();
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("   /html/body/div[4]/form/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown.Click();
            Thread.Sleep(500);
            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_option_selected\"]"));
            timeOption.Click();
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("TestRepo");
            // Enter description into the Description textbox
            IWebElement descriptionInput = driver.FindElement(By.Id("Description"));
            descriptionInput.SendKeys("Testing");
            // Enter price into the Price per unit textbox
            IWebElement inputTag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            inputTag.Click();
            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("2310");
            // Click on "Save" button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(2000);
            goToLastpage(driver);


        }

        public string GetCode(IWebDriver driver)
        {
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            return newCode.Text;

        }
        public string GetDescription(IWebDriver driver)
        {
            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            return newDescription.Text;
        }

        public string GetPrice(IWebDriver driver)
        {
            IWebElement newPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));
            return newPrice.Text;
        }

       

        

        public void edit(IWebDriver driver, string Description, string Code, string Price)
        {

            goToLastpage(driver);
            IWebElement editedCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]"));

            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();
            Thread.Sleep(500);
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            //Clear previou code before providing new code
            codeTextbox.Clear();
            codeTextbox.SendKeys(Code);
            // Enter description into the Description textbox
            IWebElement descriptionInput = driver.FindElement(By.Id("Description"));
            //Clear description text before entering new description text
            descriptionInput.Clear();
            descriptionInput.SendKeys(Description);
            // Enter price into the Price per unit textbox
            IWebElement inputTag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            inputTag.Click();
            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            //Clear previous price before entering new price
            priceTextbox.Clear();
            inputTag.Click();
            priceTextbox.SendKeys(Price);
            // Click on "Save" button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(3000);
            goToLastpage(driver);




        }
        public void goToLastpage(IWebDriver driver)
        {
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(1000);

            //deleting last record
           
        }
        public string getLastRecord(IWebDriver driver)
        {
            
          IWebElement lastRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]")); 
            return lastRecord.Text;
        }
        public   void delete(IWebDriver driver)
        {
            Thread.Sleep(1000);
           
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();
            Thread.Sleep(500);
            driver.SwitchTo().Alert().Accept();
            
            
        }
      


       
    }
}
