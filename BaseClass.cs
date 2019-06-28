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

        public static void OpenAHRIHomePage()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            Driver.Navigate().GoToUrl("https://www.ahridirectory.org");
        }
    }
}
