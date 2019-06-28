using System;
using System.Threading;
using AHRI_Unit_Test_Project.Residential;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AHRI_Unit_Test_Project.Residential.AirConditionersAndHeatPumps.AirConditionersAndAirConditionerCoils
{
    [TestFixture]
    public class AirConditionersAndAirConditionerCoilsTests : BaseClass
    {
        [Test]
        public void AirConditionersAndAirConditionerCoilsTest()
        {
            try
            {
                BaseClass.OpenBrowser();
                NavigateTo("https://www.ahridirectory.org");
                var pageMap = new AirConditionersAndAirConditionerCoilsPage();
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
