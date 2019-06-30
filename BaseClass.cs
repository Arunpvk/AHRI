using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AHRI_Unit_Test_Project
{
    public class BaseClass
    {
        public BaseClass()
        {
            

        }

        public static IWebDriver Driver = null;
        public static WebDriverWait wait = null;

        public static void OpenAHRIHomePage()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            Driver.Navigate().GoToUrl("https://www.ahridirectory.org");
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(60));


        }
    }
}
