using System;
using TechTalk.SpecFlow;

using System;
using TechTalk.SpecFlow;
using MarsQAProfile.Hooks;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using SpecFlowProject1.Pages;
using OpenQA.Selenium;
using SpecFlowProject1.Utilities;
using Microsoft.VisualStudio.TestPlatform.PlatformAbstractions.Interfaces;
using System.Reflection.Emit;
using MarsQAProfile.Drivers;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class ProfileFeatureStepDefinitions : Driver
    {
        Profile pr = new Profile();
        Login lg = new Login();

       
        [Given(@"I logged into QAMars Project successfully")]
        public void GivenILoggedIntoQAMarsProjectSuccessfully()
        {
             lg.login();
            
        }

        [When(@"I entered and saved name")]
        public void WhenIEnteredAndSavedName()
        {
           
            pr.AddName();
        }

        [Then(@"the profile page should show the added name successfully\.")]
        public void ThenTheProfilePageShouldShowTheAddedNameSuccessfully_()
        {
            pr.CheckName();
        }

        [When(@"I entered and saved description")]
        public void WhenIEnteredAndSavedDescription()
        {
           
            pr.AddDescription();
        }

        [Then(@"the profile page should show the added description\.")]
        public void ThenTheProfilePageShouldShowTheAddedDescription_()
        {
            pr.CheckDescription();
        }

        [When(@"I selected the availability option")]
        public void WhenISelectedTheAvailabilityOption()
        {
            pr.SelectAvailability();
        }

        [Then(@"the profile page should show the selected availability option\.")]
        public void ThenTheProfilePageShouldShowTheSelectedAvailabilityOption_()
        {
            pr.CheckAvailability();
        }

        [When(@"I selected the suitable option for hours")]
        public void WhenISelectedTheSuitableOptionForHours()
        {
            pr.SelectHours();
        }

        [Then(@"the profile page should show the selected hours option\.")]
        public void ThenTheProfilePageShouldShowTheSelectedHoursOption_()
        {
            pr.CheckHours();
        }

        [When(@"I selected the suitable option for earn target")]
        public void WhenISelectedTheSuitableOptionForEarnTarget()
        {
            pr.SelectEarnTarget( );
        }

        [Then(@"the profile page should show the selected earn target option\.")]
        public void ThenTheProfilePageShouldShowTheSelectedEarnTargetOption_()
        {
            pr.CheckEarnTarget( );
        }
             
       
        [When(@"I added Skills and slect option for level in profile page")]
        public void WhenIAddedSkillsAndSlectOptionForLevelInProfilePage()
        {
            pr.AddSkills();
        }

        [Then(@"the profile page should show the added Skills and level selected on profile page\.")]
        public void ThenTheProfilePageShouldShowTheAddedSkillsAndLevelSelectedOnProfilePage_()
        {
            pr.CheckSkills();
        }
       

        [When(@"I added college/university name, degree and slect option for country, title and year of graduation in profile page")]
        public void WhenIAddedCollegeUniversityNameDegreeAndSlectOptionForCountryTitleAndYearOfGraduationInProfilePage()
        {
            pr.AddEducation();
        }

        [Then(@"the profile page should show the added college/university name, degree  along with selected options for country, title and year of graduation on profile page\.")]
        public void ThenTheProfilePageShouldShowTheAddedCollegeUniversityNameDegreeAlongWithSelectedOptionsForCountryTitleAndYearOfGraduationOnProfilePage_()
        {
            pr.CheckEducation();
        }

       

        [When(@"I added '([^']*)' and slect option for '([^']*)' in profile page")]
        public void WhenIAddedAndSlectOptionForInProfilePage(string language, string level)
        {
            pr.AddNewLanguages( language, level);
        }

        [Then(@"the profile page should show the added '([^']*)' and '([^']*)' selected on profile page\.")]
        public void ThenTheProfilePageShouldShowTheAddedAndSelectedOnProfilePage_(string language, string level)
        {
            pr.CheckLanguage( language, level);
        }
        [When(@"I added '([^']*)', issued '([^']*)' and slect option for '([^']*)' of certification in profile page")]
        public void WhenIAddedIssuedAndSlectOptionForOfCertificationInProfilePage(string certificate, string institute, string year)
        {
            pr.AddCertificate( certificate, institute, year);
        }

        [Then(@"the profile page should show the added '([^']*)', issued '([^']*)' along with selected  '([^']*)' of certificationon profile page\.")]
        public void ThenTheProfilePageShouldShowTheAddedIssuedAlongWithSelectedOfCertificationonProfilePage_(string certificate, string institute, string year)
        {
            pr.CheckCertificate ( certificate, institute, year);
        }


    }
}
