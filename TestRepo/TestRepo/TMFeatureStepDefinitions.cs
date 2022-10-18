using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TestRepo.Utilities;

namespace TestRepo
{
    [Binding]
    public class TMFeatureStepDefinitions: CommonDriver
    {
        [Given(@"I logged into turn up portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            driver = new ChromeDriver();
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

        [When(@"I navigate to Time and Material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {

            IWebElement adminDropDown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminDropDown.Click();

            IWebElement TM = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul/ li[5] / ul / li[3] / a"));

            TM.Click();
            Thread.Sleep(500);
        }

        [When(@"I create a new time and material record")]
        public void WhenICreateANewTimeAndMaterialRecord()
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

        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("/ html / body / div[4] / div / div / div[4] / a[4] / span"));
            goToLastPageButton.Click();
            Thread.Sleep(2000);
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(newCode.Text == "TestRepo", "Time record hasn't been created.");
        }
    }
}
