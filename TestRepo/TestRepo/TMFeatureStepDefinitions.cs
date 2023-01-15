using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Diagnostics;
using TechTalk.SpecFlow;
using TestRepo.Pages;
using TestRepo.Utilities;

namespace TestRepo
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        Homepage hp = new Homepage();
        TM_Page page = new TM_Page();
        

        [Given(@"I logged into turn up portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            LoginPage();
        }

        [When(@"I navigate to Time and Material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {

            hp.GoToTMPage(driver);
        }

        [When(@"I create a new time and material record")]
        public void WhenICreateANewTimeAndMaterialRecord()
        {
            page.create(driver);
        }
        
        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {   string newCode = page.GetCode(driver);
            string newDescription = page.GetDescription(driver);
            string newPrice = page.GetPrice(driver);
            

            Assert.That(newCode == "TestRepo", "Time record hasn't been created.");
            Assert.That(newDescription == "Testing", "New description and expected description do not match.");
            Assert.That(newPrice == "$2,310.00", "New price and expected price do not match.");
        }

       

        [Then(@"I delete an existing time and material record successfully")]
        public void ThenIDeleteAnExistingTimeAndMaterialRecord()
        {
            page.goToLastpage(driver);
            string lastRecord = page.getLastRecord(driver);
            page.delete(driver);
            Thread.Sleep(1000);
            string newlastRecord = page.getLastRecord(driver);
            Assert.That(lastRecord != newlastRecord);
        }

        [When(@"I update '([^']*)', '([^']*)' and '([^']*)' on an existing time and material record")]
        public void WhenIUpdateAndOnAnExistingTimeAndMaterialRecord(string description, string code, string price)
        {
            page.edit(driver, description, code, price);
        }



        [Then(@"The record should have the updated '([^']*)', '([^']*)' and '([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdatedAnd(string description, string code, string price)
        {
            string neweditedCode = page.GetCode(driver);
            string neweditedDescription = page.GetDescription(driver);
            string neweditedPrice = page.GetPrice(driver);

            Assert.That(neweditedCode == code, "Time record hasn't been created.");
            Assert.That(neweditedDescription == description, "New description and expected description do not match.");
            Assert.That(neweditedPrice == price, "New price and expected price do not match.");
        }

    }
}
