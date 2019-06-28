using OpenQA.Selenium;

namespace AHRI_Unit_Test_Project.Residential.AirConditionersAndHeatPumps.AirConditionersAndAirConditionerCoils
{
    class AirConditionersAndAirConditionerCoilsPageMap : CommonPageMap
    {
        public IWebElement AirConditionersandAirConditionerCoilsMenu => Driver.FindElement(By.Id("ui-id-2"));
    }
}
