using Framework.DriverCore;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Google.PageObject
{
    public class HomePage : WebDriverAction
    {
        public HomePage(IWebDriver? driver) : base(driver)
        {
        }
        private string sbSearch = "//*[@aria-label='Tìm kiếm']";
        private string btnSearch = "//*[@class='FPdoLc lJ9FBc']//*[@name='btnK']";


        public Boolean IsGoogleHomePageDisplayed()
        {
            try
            {
                WaitForElementToBeVisible(sbSearch);              
                TestContext.WriteLine("Go to Google Home page successfully");
                return true;
            }
            catch
            {
                TestContext.WriteLine("Go to Google Home page failed");
                return false;
            }
        }

        public void InputTextToSearchBox(string key)
        {
            SendKeys_(sbSearch, key);
        }


        public void PressEnter()
        {
            FindElementByXpath(sbSearch).SendKeys(Keys.Enter);
        }
    }
}
