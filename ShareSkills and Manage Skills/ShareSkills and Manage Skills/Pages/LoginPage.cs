using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using CompetitionTask1.Utilities;

namespace CompetitionTask1.Pages
{
    public class LoginPage : CommonDriver
    {

        //identify signin button and click on it

        [FindsBy(How = How.XPath, Using = "//a[@class='item']")]
        public IWebElement signInbutton { get; set; }


        //identify username textbox and enter
        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement usernameTextbox { get; set; }


        //identify password textbox and enter
        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement passwordTextbox { get; set; }


        //identify login button and click on it
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Login')]")]
        //[CacheLookup]
        public IWebElement loginButton { get; set; }

        public void LoginSteps(IWebDriver driver)
        {
                        
            PageFactory.InitElements(driver, this);
           
               //  ExcelReader.ReadDataTable(stream, "Login");                           
               // signInbutton.Click();
               // usernameTextbox.SendKeys(ExcelReader.ReadData(1, "UserName"));
               // passwordTextbox.SendKeys(ExcelReader.ReadData(1, "Password"));
               // loginButton.Click();
           
             signInbutton.Click();
             usernameTextbox.SendKeys(LoginCredentials.String1);
             passwordTextbox.SendKeys(LoginCredentials.String2);
             loginButton.Click();
             Wait.WaitToBeClickable(driver, "XPath", "//a[contains(text(),'Share Skill')]", 10);

       
        }
    }    
}



    

