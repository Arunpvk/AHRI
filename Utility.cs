using OpenQA.Selenium;

namespace AHRI_Unit_Test_Project
{
    public class Utility : BaseClass
    {
        public static int SearchResultsTableRowCount()
        {
            return Driver.FindElements(By.XPath("//table[@id='tblResults']/tbody/tr")).Count;
        }
    }
}
