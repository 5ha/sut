using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace WebTests
{
    internal class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static string BaseAddress { get { return ConstantsUtils.Url;  } }

        internal static void Initialize()
        {
            Instance = new ChromeDriver();
            TurnOnWait();
            Instance.Manage().Window.Maximize();
        }

        public static void Navigate()
        {
            Instance.Navigate().GoToUrl(BaseAddress);
        }

        private static void TurnOnWait()
        {
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        internal static void Close()
        {
            Instance.Close();
        }
    }
}