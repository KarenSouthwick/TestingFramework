using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace PlatformAutomation1
{
    public class Driver
    {
        public static IWebDriver Instance { get; internal set; }

        public static void Initialize()
        {
            Instance = new ChromeDriver(chromeDriverDirectory: @"C:\Libraries");
            //Instance.Manage().Timeouts().ImplicitWait(TimeSpan.FromSeconds(5));
        }

        public static void Close()
        {
            Instance.Close();
        }
    }
}
