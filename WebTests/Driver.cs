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
            ChromeOptions options= new ChromeOptions();
            options.AddArgument("headless");
            Instance = new ChromeDriver(options);

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