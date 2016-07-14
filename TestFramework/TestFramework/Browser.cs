using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TestFramework
{
    public static class Browser
    {
        static IWebDriver webDriver = new FirefoxDriver();


        public static string Title => webDriver.Title;

        public static IWebDriver Driver
        {
            get
            {
                return webDriver;
            }
        }

        public static void Goto(string url)
        {
            webDriver.Url = url;
        }

        public static void Close()
        {
            webDriver.Close();
        }
    }
}