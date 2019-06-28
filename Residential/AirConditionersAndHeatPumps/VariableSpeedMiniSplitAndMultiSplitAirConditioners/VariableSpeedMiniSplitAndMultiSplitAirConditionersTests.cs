using System;
using System.Threading;
using AHRI_Unit_Test_Project.Residential;
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
                BaseClass.OpenAHRIHomePage();                
                var pageMap = new VariableSpeedMiniSplitAndMultiSplitAirConditionersPage();
                pageMap.QuickSearch();
                pageMap.VerifyTableResults();
                //Assert.IsTrue(Utility.SearchResultsTableRowCount() > 1);  //If we have results in the table
            }
            finally
            {
                Driver.Quit();
            }
        }
    }
}
