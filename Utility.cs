using OpenQA.Selenium;
using System;
using System.IO;

namespace AHRI_Unit_Test_Project
{
    public class Utility : BaseClass
    {
        public static int SearchResultsTableRowCount()
        {
            return Driver.FindElements(By.XPath("//table[@id='tblResults']/tbody/tr")).Count;
        }

        public static bool DoesFileExist(string fileName = "AHRICertificate")
        {
            string sysPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string filePath = string.Format(@"{0}\Downloads\{1}.pdf", sysPath,fileName);
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                return true;
            }
            return false;

        }
    }
}
