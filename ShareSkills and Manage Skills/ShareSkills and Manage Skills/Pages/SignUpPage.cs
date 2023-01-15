using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using CompetitionTask1.Utilities;
using CompetitionTask1.Input;

namespace CompetitionTask1.Pages
{
    public class SignUpPage : CommonDriver
    {
        
            [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Join')]")]
            public IWebElement joinButton { get; set; }

            [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/div[1]/input[1]")]
            public IWebElement firstNamebox { get; set; }

            [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/div[2]/input[1]")]
            public IWebElement lastNamebox { get; set; }

            [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/div[3]/input[1]")]
            public IWebElement emailTextbox { get; set; }

            [FindsBy(How = How.XPath, Using = "//body/div[2]/div[1]/div[1]/form[1]/div[4]/input[1]")]
            public IWebElement passwordTextbox { get; set; }

            [FindsBy(How = How.XPath, Using = "//body/div[2]/div[1]/div[1]/form[1]/div[5]/input[1]")]
            public IWebElement confirmPassword { get; set; }

            [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/div[6]/div/div/input[1]")]
            public IWebElement agreeCheckbox { get; set; }

            [FindsBy(How = How.XPath, Using = "//*[@id=\"submit-btn\"]")]
            public IWebElement submitButton { get; set; }
         public void SignUpSteps(IWebDriver driver)
         {
            PageFactory.InitElements(driver, this);
            
            
            ExcelReader.ReadDataTable(stream, "Signup");
            joinButton.Click();
          
            firstNamebox.Click();
            firstNamebox.SendKeys(ExcelReader.ReadData(1, "Firstname"));

            lastNamebox.Click();
            lastNamebox.SendKeys(ExcelReader.ReadData(1, "Lastname"));

            emailTextbox.Click();
            emailTextbox.SendKeys(ExcelReader.ReadData(1, "EmailId"));

            passwordTextbox.Click();
            passwordTextbox.SendKeys(ExcelReader.ReadData(1, "Password"));

            confirmPassword.Click();
            confirmPassword.SendKeys(ExcelReader.ReadData(1, "Confirmpassword"));

            agreeCheckbox.Click();
            submitButton.Click();

        }

    }

}
