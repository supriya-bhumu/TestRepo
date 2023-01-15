using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CompetitionTask1.Utilities;
using System.IO;
using AventStack.ExtentReports;
using CompetitionTask1.Input;
using CompetitionTask1.Pages;
using NUnit.Framework;
using CompetitionTask1.Screenshots;
using SeleniumExtras.PageObjects;
using ExcelDataReader;
using OpenQA.Selenium;
using CompetitionTaskShareSkills.Pages;

namespace CompetitionTask1.Tests
{
    [TestFixture]
    public class ShareSkill_Tests : CommonDriver
    {
       
        ProfilePage profilepageObj = new ProfilePage();
        ShareSkillsPage shareskillpageObj = new ShareSkillsPage();
        ManageListingsPage managelistingspageObj = new ManageListingsPage();
        


        [Test, Order(1)]


        public void CreateShareSkillTest()
        {
           
            
                test = extentreportObj.CreateTest("CreateSkills", "Testing Create Skills");
                profilepageObj.GoToShareSkillPage(driver);
                shareskillpageObj.CreateShareSkill(driver);
                PageFactory.InitElements(driver, this);
                CommonDriver.UseWait();
                TakeScreenShot.SSMethod(driver);
                test.Log(Status.Info, "Skills created successfully");
                test.Log(Status.Pass, "Test passed");
           
        }


        [Test, Order(2)]

        public void ViewShareSkillsTest()
        {
            try
            {

                test = extentreportObj.CreateTest("ViewSkills", "Testing Created Skills");
                profilepageObj.GoToManageListingsPage(driver);
                PageFactory.InitElements(driver, this);
                managelistingspageObj.ViewListings(driver);
                Thread.Sleep(2000);
                TakeScreenShot.SSMethod(driver);
                test.Log(Status.Info, "View Shareskills page opened successfully");
                test.Log(Status.Pass, "Test passed");
            }
            catch
            {
                test.Log(Status.Fail, "Test Failed");
            }
        }

        [Test, Order(3)]
        public void EditShareSkillTest()
        {
           
               
                
                test = extentreportObj.CreateTest("EditSkills", "Testing Created Skills");
                profilepageObj.GoToManageListingsPage(driver);
                managelistingspageObj.GoToShareSkillPage(driver);
                shareskillpageObj.EditShareSkill(driver);
                CommonDriver.UseWait();                           
                TakeScreenShot.SSMethod(driver);
                test.Log(Status.Info, "Skills edited successfully");
                test.Log(Status.Pass, "Test passed");
                
             
                
            }
           

        [Test, Order(4)]

        public void DeleteShareSkillTest()
        {
            try
            {
                test = extentreportObj.CreateTest("DeleteSkills", "Deleting skills created");
                profilepageObj.GoToManageListingsPage(driver);
                managelistingspageObj.DeleteShareSkill(driver);
                CommonDriver.UseWait();
                TakeScreenShot.SSMethod(driver);
                test.Log(Status.Info, "Skill listing deleted successfully");
                test.Log(Status.Pass, "Test passed");
            }
            catch(Exception ex)
            {
                TakeScreenShot.SSMethod(driver);
                test.Log(Status.Fail, "Test Failed");
                Assert.Fail("Delete Skills Test failed", ex.Message);
                throw;
            }

        }

    }

} 
    



    

