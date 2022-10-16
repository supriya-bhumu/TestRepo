using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestRepo.Pages;
using TestRepo.Utilities;
using static System.Net.Mime.MediaTypeNames;
namespace TestRepo.Tests
{
    [TestFixture]
    [Parallelizable]
   


    public class TM_Tests : CommonDriver
    {
        
        Login lg = new Login();
        Homepage hp = new Homepage();
        TM_Page page = new TM_Page();

        


        [SetUp]
        public void LoginPage()
        {
            
             driver = new ChromeDriver();
            lg.login(driver);
            hp.GoToTMPage(driver);
        }
      
      
        [Test, Order(1), Description("This test creates a new TM record")]
        public void CreateTMTest()
        {
            page.create(driver);
        }
        [Test, Order(2), Description("This test edits TM record")]
        public void EditTMTest()
        {
            page.edit(driver);
        }
        [Test, Order(3), Description("This test deletes TM record")]
        public void DeleteTMTest()
        {
            page.delete(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }

    }
}