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
        Homepage hp = new Homepage();
        TM_Page page = new TM_Page();

        [Test, Order(1), Description("This test creates a new TM record")]
        public void CreateTMTest()
        {
            hp.GoToTMPage(driver);
            page.create(driver);
        }
        [Test, Order(2), Description("This test edits TM record")]
        public void EditTMTest()
        {
            hp.GoToTMPage(driver);
            page.edit(driver);
        }
        [Test, Order(3), Description("This test deletes TM record")]
        public void DeleteTMTest()
        {
            hp.GoToTMPage(driver);
            page.delete(driver);
        }
    }
}