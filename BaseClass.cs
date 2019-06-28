using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AHRI_Unit_Test_Project
{
    public class BaseClass
    {
        public BaseClass()
        {
            

        }

        public static IWebDriver Driver = null;

        public void NavigateTo(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public static void OpenBrowser()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
        }
    }
}
