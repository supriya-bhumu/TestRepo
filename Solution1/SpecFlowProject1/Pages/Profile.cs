
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SpecFlowProject1.Utilities;
using static System.Collections.Specialized.BitVector32;
using System.Security.Principal;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using App.Metrics;

namespace SpecFlowProject1.Pages
{
    public class Profile 
    {

        

        //Method for Identifying firstname and last name text box , delete if any pre existing data is there and and entering prefereed name data.
        
        public void AddName(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            IWebElement DropdownIcon = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i")));

            //IWebElement DropdownIcon =driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));

            IWebElement FirstName = driver.FindElement(By.Name("firstName"));
            IWebElement LastName = driver.FindElement(By.Name("lastName"));

            IWebElement SaveButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/button"));
            
            DropdownIcon.Click();
            Thread.Sleep(2000);
            FirstName.Clear();
            FirstName.SendKeys("MarySupriya");
            LastName.Clear();
            LastName.SendKeys("Bhumu");
            SaveButton.Click();
            Thread.Sleep(2000);
        }


        //Method for Checking if the given name details are visible on profile page
        public  void CheckName(IWebDriver driver)
        {
            IWebElement Title = driver.FindElement(By.ClassName("title"));
            Assert.That(Title.Text == "MarySupriya Bhumu", "Name hasn't been added");
           
        }


        //Method to delete if any previously existing description is there and add the new Description to it.
       public void AddDescription(IWebDriver driver)
        {           
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            IWebElement DescriptionPen = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i")));
            //IWebElement AddNew = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            DescriptionPen.Click();
            Thread.Sleep(1000);
            IWebElement DescriptionTextArea = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea")));
            DescriptionTextArea.Click();
            DescriptionTextArea.Clear();
            DescriptionTextArea.SendKeys("I Have finished my Graduate Diploma in IT.");
            IWebElement DescriptionSaveButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            DescriptionSaveButton.Click();
            Thread.Sleep(2000);
        }


        //Method to check if the given description is visible in profile page.
        public void CheckDescription(IWebDriver driver)
        {
            IWebElement Description = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/span"));
            Assert.That(Description.Text == "I Have finished my Graduate Diploma in IT.","Description not added");
        }


        //Method to choose and update the avilability option
        public void SelectAvailability(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            IWebElement AvailabilitySelector = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i")));
            AvailabilitySelector.Click();
            Thread.Sleep(500);
            IWebElement AvailabilityDropDown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select"));
            AvailabilityDropDown.Click();
            Thread.Sleep(500);
            IWebElement SelectedAvailability = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select/option[3]"));
            SelectedAvailability.Click();
        
        }


        //Check if the choosen availability is visible in profile page
        public void CheckAvailability(IWebDriver driver)
        {
            IWebElement NewAvailability = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span"));
            Assert.That(NewAvailability.Text == "Full Time", "Availability not added");
        }


        //Method to choose the hours and update them
        public void SelectHours(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            IWebElement HoursSelector = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i")));
            HoursSelector.Click();
            Thread.Sleep(500);
            IWebElement HoursDropDown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select"));
            HoursDropDown.Click();
            Thread.Sleep(500);
            IWebElement SelectedHours = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select/option[2]"));
            SelectedHours.Click();
            
        }


        //Check if the choosen hours visible on Profile page.
        public void CheckHours(IWebDriver driver)
        {
            IWebElement NewHours = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span"));
            Assert.That(NewHours.Text == "Less than 30hours a week", "Hours not added");
        }


        //Method to choose the earn target and update 
        public void SelectEarnTarget(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            IWebElement EarnTargetSelector = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i")));
            EarnTargetSelector.Click();
            Thread.Sleep(500);
            IWebElement EarnTargetDropDown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select"));
            EarnTargetDropDown.Click();
            Thread.Sleep(500);
            IWebElement SelectedEarnTarget = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select/option[3]"));
            SelectedEarnTarget.Click();
        }


        //Method to check if the choosen earn target is visible in Profile page or not
        public void CheckEarnTarget(IWebDriver driver)
        {
            IWebElement NewEarnTarget = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span"));
            Assert.That(NewEarnTarget.Text == "Between $500 and $1000 per month", "Earn Target not added");
        }


        //Method to add language and choose its level
        public void AddNewLanguages(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            IWebElement AddNewLanguageButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"))) ;
            AddNewLanguageButton.Click();
            IWebElement NewLanguageName = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            NewLanguageName.SendKeys("English");
            IWebElement ChooseLanguageLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            ChooseLanguageLevel.Click();
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]")).Click();
            Thread.Sleep(200);
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(" //*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"))).Click();
         
        }


        //Method to check if the added language and its level is visible in profile page 
        public void CheckLanguage(IWebDriver driver)
        {
            Thread.Sleep(500);
            IWebElement NewLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            IWebElement NewLanguageLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
            Assert.That(NewLanguage.Text == "English", "Language not added");
            Assert.That(NewLanguageLevel.Text == "Conversational", "Level Not Added");

        }


        //Method to add skills and to choose its level
        public void AddSkills(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            IWebElement SkillForm = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")));
            SkillForm.Click();
            Thread.Sleep(500);
            IWebElement AddNewSkillsButton =driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNewSkillsButton.Click();
            IWebElement NewSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            NewSkill.SendKeys("Speckflow BDD with c#");
            IWebElement ChooseSkillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            ChooseSkillLevel.Click();
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]")).Click();
            Thread.Sleep(200);
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(" //*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"))).Click();

        }


        //Method to check if the added skill and choosen level is visible on profile page
        public void CheckSkills(IWebDriver driver)
        {
            Thread.Sleep(500);
            IWebElement NewSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            IWebElement NewSkillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));
            Assert.That(NewSkill.Text == "Speckflow BDD with c#", "Language not added");
            Assert.That(NewSkillLevel.Text == "Intermediate", "Level Not Added");

        }



        //Method to add Education details 
        public void AddEducation(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            IWebElement EducationForm = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")));
            EducationForm.Click();
            Thread.Sleep(500);
            IWebElement AddNewEducationButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            Thread.Sleep(200);
            AddNewEducationButton.Click();
            IWebElement CollegeName = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
            CollegeName.SendKeys("CQ University");
            IWebElement ChooseCountry = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            ChooseCountry.Click();
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[11]")).Click();
            IWebElement ChooseTitle = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
            ChooseTitle.Click();
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[8]")).Click();
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input")).SendKeys("Masters In Information Technology");
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select")).Click();
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[2]")).Click();
            Thread.Sleep(200);
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(" //*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"))).Click();

        }


        //Method to check if the added details of education is visible in profile page 
        public void CheckEducation(IWebDriver driver)
        {
            Thread.Sleep(500);
            IWebElement Country = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]"));
            IWebElement University = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));
            IWebElement Title = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[3]"));
            IWebElement Degree= driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[4]"));
            IWebElement Year = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[5]"));
            Assert.That(Country.Text == "Australia", "Country not added");
            Assert.That(University.Text == "CQ University", "University Not Added");
            Assert.That(Title.Text == "M.Tech", "Title not added");
            Assert.That(Degree.Text == "Masters In Information Technology", "Degree Not Added");
            Assert.That(Year.Text == "2022", "Year not added");
          

        }


        //Method to add certification details
        public void AddCertificate(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            IWebElement CertificationForm = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")));
            CertificationForm.Click();
            Thread.Sleep(500);
            IWebElement AddNewCertificationButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            Thread.Sleep(200);
            AddNewCertificationButton.Click();
            IWebElement Certification = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
            Certification.SendKeys("Java Basic");
            IWebElement Organization = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            Organization.SendKeys("HackerRank");
            IWebElement ChooseYear = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
            ChooseYear.Click();
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[3]")).Click();
            Thread.Sleep(200);
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]")).Click();


        }


        //Method to check if the added certification details visible on profile page
        public void CheckCertificate(IWebDriver driver)
        {
            Thread.Sleep(500);
            IWebElement Certificate= driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
            IWebElement From = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[2]"));
            IWebElement Year = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[3]"));
           
            Assert.That(Certificate.Text == "Java Basic", "Certificate not added");
            Assert.That(From.Text == "HackerRank", "From Not Added");
            Assert.That(Year.Text == "2021", "Year not added");
            

        }





    }
}
