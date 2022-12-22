using CoreFramework.NunitTestSetUp;
using Google.Common;
using NUnit.Framework;

namespace Google.TestSetUp
{
    public class NunitWebTestSetUp : NunitTestSetUp
    {
        [SetUp]
        public void SetUp()
        {
            var constant = Utils.ReadConstantInfoFromFile(@"./Constant.json");
            driverBaseAction.GoToUrl(constant.BaseUrl);
        }

        [TearDown]
        public void TearDown()
        {
            driverBaseAction.Quit();
        }
    }
}
