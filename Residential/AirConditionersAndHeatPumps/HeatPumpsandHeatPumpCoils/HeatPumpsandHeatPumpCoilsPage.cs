﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHRI_Unit_Test_Project.Residential.AirConditionersAndHeatPumps.HeatPumpsandHeatPumpCoils
{
    class HeatPumpsandHeatPumpCoilsPage : HeatPumpsandHeatPumpCoilsPageMap
    {
        
        internal void QuickSearch()
        {
            SearchProductMenu.Click();
            ResidentialMenu.Click();
            AirConditionersandHeatPumpsMenu.Click();
            HeatPumpsAndHeatPumpCoils.Click();
        }

        
    }
}
