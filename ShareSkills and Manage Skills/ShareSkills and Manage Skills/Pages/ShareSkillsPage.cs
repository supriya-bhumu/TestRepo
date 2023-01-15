using NUnit.Framework;
using OpenQA.Selenium;
using AventStack.ExtentReports;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using CompetitionTask1.Utilities;
using System.Data;
using CompetitionTask1.Input;
using ExcelDataReader;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;
using AutoItX3Lib;



namespace CompetitionTask1.Pages
{
    public class ShareSkillsPage
    {


        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input")]
        public IWebElement titleTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea")]
        public IWebElement descriptionTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[1]/select")]
        public IWebElement categoryDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div/select/option[7]")]
        public IWebElement progammingOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div/select/option[6]")]
        public IWebElement musicOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select")]
        public IWebElement subCategorydropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[5]")]
        public IWebElement qaOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[5]")]
        public IWebElement otherOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[4]/div[2]/div[1]/div[1]/div[1]/div[1]/input[1]")]
        public IWebElement tagsTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input")]
        public IWebElement tag2Textbox {get; set;}

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input")]
        public IWebElement hourlyServicetype;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input")]
        public IWebElement oneOffServicetype;

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input")]
        public IWebElement onsiteLocation;

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input")]
        public IWebElement onlineLocation;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input")]
        public IWebElement availableStartdate { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input")]
        public IWebElement endDate { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input")]
        public IWebElement selectMonday { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input")]
        public IWebElement monStarttime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input")]
        public IWebElement monEndtime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\'service - listing - section\"]/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input")]
        public IWebElement skillTradeExchange { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input")]
        public IWebElement skillTradeCredit { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input")]
        public IWebElement skillExchangetag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/input")]
        public IWebElement perHourcredit { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i")]
        public IWebElement workSamples { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input")]
        public IWebElement activeCheckbox;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[1")]
        public IWebElement selectHidden;

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]")]
        public IWebElement saveButton;

        public void CreateShareSkill(IWebDriver driver)
        {
                     
            PageFactory.InitElements(driver, this);

            string title = ExcelReader.ReadData(1, "Title");
            titleTextbox.SendKeys(title);

            string description = ExcelReader.ReadData(1, "Description");
            descriptionTextbox.SendKeys(description);

            categoryDropdown.Click();
            SelectElement selectCategory = new SelectElement(categoryDropdown);
            selectCategory.SelectByText(ExcelReader.ReadData(2, "Category"));
            progammingOption.Click();


            subCategorydropdown.Click();
            SelectElement selectSubCategory = new SelectElement(subCategorydropdown);
            selectSubCategory.SelectByText(ExcelReader.ReadData(2, "SubCategory"));
            qaOption.Click();


            string tag = ExcelReader.ReadData(1, "Tags");
            tagsTextbox.SendKeys(tag);
            tagsTextbox.SendKeys(Keys.Enter);

            tag2Textbox.Click();
            string newTagName = ExcelReader.ReadData(1, "Tag2");
            tag2Textbox.SendKeys(newTagName);
            CommonDriver.UseWait();

            oneOffServicetype.Click();

            onlineLocation.Click();

            string startDateOn = ExcelReader.ReadData(1, "StartDate");
            availableStartdate.SendKeys(startDateOn);

            string endDateOn = ExcelReader.ReadData(1, "EndDate");
            endDate.SendKeys(endDateOn);

            selectMonday.Click();

            string startTime = ExcelReader.ReadData(1, "DayStartTime");
            monStarttime.SendKeys(startTime);

            string endTime = ExcelReader.ReadData(1, "DayEndTime");
            monEndtime.SendKeys(endTime);


            string skillExchangeTag = ExcelReader.ReadData(1, "SkillExchangeTag");

            skillExchangetag.SendKeys(skillExchangeTag);
            skillExchangetag.SendKeys(Keys.Enter);

            workSamples.Click();
            Thread.Sleep(2000);

            using (Process exeProcess = Process.Start(@"C:\Testing\sampletest\CompetitionTask1\CompetitionTask1\AutoIT\WorkSample.exe"))
            {
                exeProcess.WaitForExit();
            }

            //approach :AutoIt Handles windows that do not belong to browser

            // AutoItX3 autoIt = new AutoItX3();
            // autoIt.WinWaitActive("Open");
            // Thread.Sleep(2000);
            // autoIt.Send(@"C:\Testing\sampletest\CompetitionTask1\CompetitionTask1\AutoIT\WorkSample.exe");
            // Thread.Sleep(2000);
            // autoIt.Send("{ENTER}");
            // Thread.Sleep(1000);

            activeCheckbox.Click();
            CommonDriver.UseWait();

            saveButton.Click();
            CommonDriver.UseWait();
        }
            
        public void EditShareSkill(IWebDriver driver)
        {
           
            PageFactory.InitElements(driver, this);
            titleTextbox.Clear();

            string editedTitle = ExcelReader.ReadData(2, "Title");
            titleTextbox.SendKeys(editedTitle);

            descriptionTextbox.Clear();
            string editedDescription = ExcelReader.ReadData(2, "Description");
            descriptionTextbox.SendKeys(editedDescription);

            categoryDropdown.Click();
            SelectElement editedCategory = new SelectElement(categoryDropdown);
            editedCategory.SelectByText(ExcelReader.ReadData(2, "Category"));
            musicOption.Click();


            subCategorydropdown.Click();
            SelectElement editedSubCategory = new SelectElement(subCategorydropdown);
            editedSubCategory.SelectByText(ExcelReader.ReadData(2, "SubCategory"));
            otherOption.Click();
            CommonDriver.UseWait();

          
            tag2Textbox.Clear();
            string editedTag2 = ExcelReader.ReadData(2, "Tag2");
            tag2Textbox.SendKeys(editedTag2);
            tag2Textbox.SendKeys(Keys.Enter);

            hourlyServicetype.Click();

            string editedStartDateOn = ExcelReader.ReadData(2, "StartDate");
            availableStartdate.SendKeys(editedStartDateOn);

            string editedEndDateOn = ExcelReader.ReadData(2, "EndDate");
            endDate.SendKeys(editedEndDateOn);

            selectMonday.Click();
            
            string editedMondayStarttime = ExcelReader.ReadData(2, "DayStartTime");
            monStarttime.SendKeys(editedMondayStarttime);

            string editedMondayEndtime = ExcelReader.ReadData(2, "DayEndTime");
            monEndtime.SendKeys(editedMondayEndtime);
            CommonDriver.UseWait();

            skillTradeCredit.Click();
         
            perHourcredit.Click();
            string creditAmount = ExcelReader.ReadData(2, "SkillCredit");
            perHourcredit.SendKeys(creditAmount);

            workSamples.Click();
            Thread.Sleep(2000);

            using (Process exeProcess = Process.Start(@"C:\Testing\sampletest\CompetitionTask1\CompetitionTask1\AutoIT\WorkSample.exe"))
            {
                exeProcess.WaitForExit();
            }

            activeCheckbox.Click();
            CommonDriver.UseWait();
            
            saveButton.Click();
            CommonDriver.UseWait();
            

            IWebElement viewEditedSkills = driver.FindElement(By.XPath("//tbody/tr[1]/td[8]/div[1]/button[1]/i[1]"));
            viewEditedSkills.Click();

            IWebElement checkEditedTitle = driver.FindElement(By.XPath("//span[contains(text(),'Singer')]"));
            Assert.That(checkEditedTitle.Text == "Singer", "Expected Title and Edited Title doesnot match");
        }
    
    }
}


      
