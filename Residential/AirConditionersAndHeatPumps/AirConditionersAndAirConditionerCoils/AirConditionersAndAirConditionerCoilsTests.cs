using NUnit.Framework;

namespace AHRI_Unit_Test_Project.Residential.AirConditionersAndHeatPumps.AirConditionersAndAirConditionerCoils
{
    [TestFixture]
    public class AirConditionersAndAirConditionerCoilsTests : BaseClass
    {
        [Test]
        public void AirConditionersAndAirConditionerCoilsTestQS()
        {
            try
            {
                BaseClass.OpenAHRIHomePage();
                var pageMap = new AirConditionersAndAirConditionerCoilsPage();
                pageMap.QuickSearch();
            }
            finally
            {
                Driver.Quit();
            }
        }

        [Test]
        public void AirConditionersAndAirConditionerCoilsTestAS()
        {
            try
            {
                BaseClass.OpenAHRIHomePage();
                var pageMap = new AirConditionersAndAirConditionerCoilsPage();
                pageMap.AdvancedSearch();
            }
            finally
            {
                Driver.Quit();
            }
        }
    }
}
