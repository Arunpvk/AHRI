using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHRI_Unit_Test_Project.Residential
{
    class CommonPageMap : BaseClass
    {
        public IWebElement SearchProductMenu => Driver.FindElement(By.Id("SearchProduct"));
        public IWebElement ResidentialMenu => Driver.FindElement(By.Id("ui-id-1"));
        public IWebElement AirConditionersandHeatPumpsMenu => Driver.FindElement(By.Id("listSubmenuPgm"));

        public string NoResults = "//table[@id='tblResults']/tbody//*[text()='Please conduct a search.']";





        public bool IsElementVisible(string xpath)
        {
            try
            {
                return Driver.FindElement(By.XPath(xpath)) != null;
            }
            catch
            {
                return false;
            }
        }

        internal void VerifyTableResults()
        {
            Assert.IsTrue(IsElementVisible(NoResults));
        }
        
    }
}
