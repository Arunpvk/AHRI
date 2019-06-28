using OpenQA.Selenium;

namespace AHRI_Unit_Test_Project.Residential.AirConditionersAndHeatPumps.VariableSpeedMiniSplitAndMultiSplitAirConditioners
{
    class VariableSpeedMiniSplitAndMultiSplitAirConditionersPageMap : CommonPageMap
    {
        public IWebElement VariableSpeedMiniSplitAndMultiSplitAirConditioners => Driver.FindElement(By.Id("ui-id-4"));              
    }
}
