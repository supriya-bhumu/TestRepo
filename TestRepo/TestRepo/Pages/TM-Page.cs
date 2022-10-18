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
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("/ html / body / div[4] / div / div / div[4] / a[4] / span"));
            goToLastPageButton.Click();
            Thread.Sleep(2000);
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(newCode.Text == "TestRepo", "Time record hasn't been created.");


        }

        public void edit(IWebDriver driver)
        {

            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(1000);
            IWebElement editedCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]"));

            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();
            Thread.Sleep(500);
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            //Clear previou code before providing new code
            codeTextbox.Clear();
            codeTextbox.SendKeys("TestRepo2");
            // Enter description into the Description textbox
            IWebElement descriptionInput = driver.FindElement(By.Id("Description"));
            //Clear description text before entering new description text
            descriptionInput.Clear();
            descriptionInput.SendKeys("Testing1");
            // Enter price into the Price per unit textbox
            IWebElement inputTag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            inputTag.Click();
            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            //Clear previous price before entering new price
            priceTextbox.Clear();
            inputTag.Click();
            priceTextbox.SendKeys("231");
            // Click on "Save" button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(3000);
            IWebElement goToLastPageButton1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton1.Click();
            Thread.Sleep(5000);
           // IWebElement editedCodenew = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]"));
            IWebElement editedname = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement editedPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));


            Assert.That(editedname.Text == "TestRepo2", "Edited code and expected code do not match.");
            Assert.That(editedDescription.Text == "Testing1", "Edited description and expected description do not match.");
            Assert.That(editedPrice.Text == "$231.00", "Edited price and expected price do not match.");



        }

        public void delete(IWebDriver driver)
        {
            //going to last page
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(1000);

            //deleting last record
            IWebElement lastRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();
            Thread.Sleep(500);
            driver.SwitchTo().Alert().Accept();
            IWebElement goToLastPageButton1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton1.Click();
            Thread.Sleep(2000);
            IWebElement newLastRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(newLastRecord != lastRecord, "Time record hasn't been deleted.");
         

        }
    }
}
