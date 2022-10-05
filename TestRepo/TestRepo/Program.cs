using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// open chrome browser

IWebDriver driver = new ChromeDriver();

// navigate to TurnUp portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
driver.Manage().Window.Maximize();

// identify username textbox and enter valid username
IWebElement usernameInput = driver.FindElement(By.Id("UserName"));
usernameInput.SendKeys("hari");

// identify password textbox and enter valid password
IWebElement passwordInput = driver.FindElement(By.Id("Password"));
passwordInput.SendKeys("123123");

// identify login button and click on it
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
loginButton.Click();

// check if user is logged in successfully
IWebElement hello = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

if (hello.Text == "Hello hari!")
{
    Console.WriteLine(" test passed.");
}
else
{
    Console.WriteLine(" test failed.");
}