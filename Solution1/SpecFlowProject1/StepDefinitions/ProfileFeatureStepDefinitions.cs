using System;
using TechTalk.SpecFlow;

using System;
using TechTalk.SpecFlow;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using SpecFlowProject1.Pages;
using OpenQA.Selenium;
using SpecFlowProject1.Utilities;
using Microsoft.VisualStudio.TestPlatform.PlatformAbstractions.Interfaces;


namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class ProfileFeatureStepDefinitions : CommonDriver
    {
        Profile pr = new Profile();
        Login lg = new Login();

       
        [Given(@"I logged into QAMars Project successfully")]
        public void GivenILoggedIntoQAMarsProjectSuccessfully()
        {
            lg.login(driver);

        }

        [When(@"I entered and saved name")]
        public void WhenIEnteredAndSavedName()
        {
           
            pr.AddName(driver);
        }

        [Then(@"the profile page should show the added name successfully\.")]
        public void ThenTheProfilePageShouldShowTheAddedNameSuccessfully_()
        {
            pr.CheckName(driver);
        }

        [When(@"I entered and saved description")]
        public void WhenIEnteredAndSavedDescription()
        {
           
            pr.AddDescription(driver);
        }

        [Then(@"the profile page should show the added description\.")]
        public void ThenTheProfilePageShouldShowTheAddedDescription_()
        {
            pr.CheckDescription(driver);
        }

        [When(@"I selected the availability option")]
        public void WhenISelectedTheAvailabilityOption()
        {
            pr.SelectAvailability(driver);
        }

        [Then(@"the profile page should show the selected availability option\.")]
        public void ThenTheProfilePageShouldShowTheSelectedAvailabilityOption_()
        {
            pr.CheckAvailability(driver);
        }

        [When(@"I selected the suitable option for hours")]
        public void WhenISelectedTheSuitableOptionForHours()
        {
            pr.SelectHours(driver);
        }

        [Then(@"the profile page should show the selected hours option\.")]
        public void ThenTheProfilePageShouldShowTheSelectedHoursOption_()
        {
            pr.CheckHours(driver);
        }

        [When(@"I selected the suitable option for earn target")]
        public void WhenISelectedTheSuitableOptionForEarnTarget()
        {
            pr.SelectEarnTarget( driver);
        }

        [Then(@"the profile page should show the selected earn target option\.")]
        public void ThenTheProfilePageShouldShowTheSelectedEarnTargetOption_()
        {
            pr.CheckEarnTarget( driver);
        }
        

        [When(@"I added language and slect option for level in profile page")]
        public void WhenIAddedLanguageAndSlectOptionForLevelInProfilePage()
        {
            pr.AddNewLanguages(driver);
        }

        [Then(@"the profile page should show the added language and level selected on profile page\.")]
        public void ThenTheProfilePageShouldShowTheAddedLanguageAndLevelSelectedOnProfilePage_()
        {
            pr.CheckLanguage( driver);
        }
        
       

        [When(@"I added Skills and slect option for level in profile page")]
        public void WhenIAddedSkillsAndSlectOptionForLevelInProfilePage()
        {
            pr.AddSkills(driver);
        }

        [Then(@"the profile page should show the added Skills and level selected on profile page\.")]
        public void ThenTheProfilePageShouldShowTheAddedSkillsAndLevelSelectedOnProfilePage_()
        {
            pr.CheckSkills(driver);
        }
       

        [When(@"I added college/university name, degree and slect option for country, title and year of graduation in profile page")]
        public void WhenIAddedCollegeUniversityNameDegreeAndSlectOptionForCountryTitleAndYearOfGraduationInProfilePage()
        {
            pr.AddEducation(driver);
        }

        [Then(@"the profile page should show the added college/university name, degree  along with selected options for country, title and year of graduation on profile page\.")]
        public void ThenTheProfilePageShouldShowTheAddedCollegeUniversityNameDegreeAlongWithSelectedOptionsForCountryTitleAndYearOfGraduationOnProfilePage_()
        {
            pr.CheckEducation(driver);
        }

       
        [When(@"I added Certificate, issued institute and slect option for year of certification in profile page")]
        public void WhenIAddedCertificateIssuedInstituteAndSlectOptionForYearOfCertificationInProfilePage()
        {
            pr.AddCertificate(driver);
        }

        [Then(@"the profile page should show the added Certificate, issued institute along with selected  year of certificationon profile page\.")]
        public void ThenTheProfilePageShouldShowTheAddedCertificateIssuedInstituteAlongWithSelectedYearOfCertificationonProfilePage_()
        {
            pr.CheckCertificate(driver);
        }


    }
}
