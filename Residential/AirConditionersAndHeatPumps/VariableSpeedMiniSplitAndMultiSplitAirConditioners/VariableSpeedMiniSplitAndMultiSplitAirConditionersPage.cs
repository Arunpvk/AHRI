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
        }

        
    }
}
