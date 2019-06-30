using NUnit.Framework;

namespace AHRI_Unit_Test_Project.Residential.AirConditionersAndHeatPumps.VariableSpeedMiniSplitAndMultiSplitAirConditioners
{
    [TestFixture]
    public class VariableSpeedMiniSplitAndMultiSplitAirConditionersTests : BaseClass
    {
        [Test]
        public void VariableSpeedMiniSplitAndMultiSplitAirConditionersTestQS()
        {
            try
            {
                BaseClass.OpenAHRIHomePage();                
                var pageMap = new VariableSpeedMiniSplitAndMultiSplitAirConditionersPage();
                pageMap.QuickSearch();                                
            }
            finally
            {
                Driver.Quit();
            }
        }
        [Test]
        public void VariableSpeedMiniSplitAndMultiSplitAirConditionersTestAS()
        {
            try
            {
                BaseClass.OpenAHRIHomePage();
                var pageMap = new VariableSpeedMiniSplitAndMultiSplitAirConditionersPage();
                pageMap.AdvancedSearch();
            }
            finally
            {
                Driver.Quit();
            }
        }
    }
}
