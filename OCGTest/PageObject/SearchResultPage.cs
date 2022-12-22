using Framework.DriverCore;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Google.PageObject
{
    public class SearchResultPage : WebDriverAction
    {
        public SearchResultPage(IWebDriver? driver) : base(driver)
        {
        }
        private string lbGoogle = "//*[@alt='Google']";

        public Boolean IsSearchResultPageDisplayed(string title)
        {
            WaitForElementToBeVisible(lbGoogle);
            if (IsTitleOfPageCorrect(title) == true)
            {
                            
                TestContext.WriteLine("Go to Search Result page successfully");
                return true;
            }
            else
            {
                TestContext.WriteLine("Go to Search Result page failed");
                return false;
            }
        }

    }
}
