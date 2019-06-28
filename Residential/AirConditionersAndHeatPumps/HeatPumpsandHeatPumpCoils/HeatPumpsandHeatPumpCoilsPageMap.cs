using OpenQA.Selenium;

namespace AHRI_Unit_Test_Project.Residential.AirConditionersAndHeatPumps.HeatPumpsandHeatPumpCoils
{
    class HeatPumpsandHeatPumpCoilsPageMap : CommonPageMap
    {
        public IWebElement HeatPumpsAndHeatPumpCoils => Driver.FindElement(By.Id("ui-id-3"));              
    }
}
