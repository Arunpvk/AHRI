using NUnit.Framework;

namespace AHRI_Unit_Test_Project.Residential.AirConditionersAndHeatPumps.HeatPumpsandHeatPumpCoils
{
    [TestFixture]
    public class HeatPumpsandHeatPumpCoilsTests : BaseClass
    {
        [Test]
        public void HeatPumpsandHeatPumpCoilsTestQS()
        {
            try
            {
                BaseClass.OpenAHRIHomePage();
                var pageMap = new HeatPumpsandHeatPumpCoilsPage();
                pageMap.QuickSearch();
            }
            finally
            {
                Driver.Quit();
            }
        }
        [Test]
        public void HeatPumpsandHeatPumpCoilsTestAS()
        {
            try
            {
                BaseClass.OpenAHRIHomePage();
                var pageMap = new HeatPumpsandHeatPumpCoilsPage();
                pageMap.AdvancedSearch();
            }
            finally
            {
                Driver.Quit();
            }
        }
    }
}
