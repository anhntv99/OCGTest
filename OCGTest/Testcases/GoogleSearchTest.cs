using Google.Common;
using Google.PageObject;
using Google.TestSetUp;
using NUnit.Framework;
using NUnit.Framework.Internal;



namespace Google.Testcases
{
    [TestFixture]
    public class GoogleSearchTest : NunitWebTestSetUp
    {


        [Test]
        public void SearchByTextAndPressEnter()
        {
            var constant = Utils.ReadConstantInfoFromFile(@"./Constant.json");
            HomePage homePage = new HomePage(_driver);
            homePage.IsGoogleHomePageDisplayed();
            homePage.InputTextToSearchBox(constant.Keyword);
            homePage.PressEnter();
            SearchResultPage searchResultPage = new SearchResultPage(_driver);
            searchResultPage.IsSearchResultPageDisplayed(constant.TitleSearchResultPage);
           
        }

    }

}
