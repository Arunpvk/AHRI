using System;
using System.Threading;
using AHRI_Unit_Test_Project.Residential;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AHRI_Unit_Test_Project.Residential.AirConditionersAndHeatPumps.VariableSpeedMiniSplitAndMultiSplitAirConditioners
{
    [TestFixture]
    public class VariableSpeedMiniSplitAndMultiSplitAirConditionersTests : BaseClass
    {
        [Test]
        public void VariableSpeedMiniSplitAndMultiSplitAirConditionersTest()
        {
            try
            {
                BaseClass.OpenBrowser();
                NavigateTo("https://www.ahridirectory.org");
                var pageMap = new VariableSpeedMiniSplitAndMultiSplitAirConditionersPage();
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
