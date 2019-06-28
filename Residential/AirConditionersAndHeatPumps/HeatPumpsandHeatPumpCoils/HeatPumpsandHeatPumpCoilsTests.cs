using System;
using System.Threading;
using AHRI_Unit_Test_Project.Residential;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AHRI_Unit_Test_Project.Residential.AirConditionersAndHeatPumps.HeatPumpsandHeatPumpCoils
{
    [TestFixture]
    public class HeatPumpsandHeatPumpCoilsTests : BaseClass
    {
        [Test]
        public void HeatPumpsandHeatPumpCoilsTest()
        {
            try
            {
                BaseClass.OpenAHRIHomePage();
                var pageMap = new HeatPumpsandHeatPumpCoilsPage();
                pageMap.QuickSearch();
                pageMap.VerifyTableResults();
            }
            finally
            {
                Driver.Quit();
            }
        }
    }
}
