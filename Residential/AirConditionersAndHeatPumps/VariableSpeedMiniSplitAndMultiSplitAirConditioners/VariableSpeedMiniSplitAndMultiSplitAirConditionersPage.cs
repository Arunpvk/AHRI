using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHRI_Unit_Test_Project.Residential.AirConditionersAndHeatPumps.VariableSpeedMiniSplitAndMultiSplitAirConditioners
{
    class VariableSpeedMiniSplitAndMultiSplitAirConditionersPage : VariableSpeedMiniSplitAndMultiSplitAirConditionersPageMap
    {
        
        internal void QuickSearch()
        {
            SearchProductMenu.Click();
            ResidentialMenu.Click();
            AirConditionersandHeatPumpsMenu.Click();
            VariableSpeedMiniSplitAndMultiSplitAirConditioners.Click();
            VerifyTableResults();
            SearchButton.Click();
            Assert.IsTrue(Utility.SearchResultsTableRowCount() > 1);
        }
        internal void AdvancedSearch()
        {
            SearchProductMenu.Click();
            ResidentialMenu.Click();
            AirConditionersandHeatPumpsMenu.Click();
            VariableSpeedMiniSplitAndMultiSplitAirConditioners.Click();
            ManufacturerType.SelectByIndex(1);
            SearchButton.Click();
            Assert.IsTrue(Utility.SearchResultsTableRowCount() > 1);
            Utility.DoesFileExist();
            FirstResultInTheTable.Click();
            try
            {
                wait.Until(Driver => Utility.DoesFileExist());
            }
            catch (Exception)
            {

                Assert.Fail("Unable to download the file");
            }
        }

    }
}
