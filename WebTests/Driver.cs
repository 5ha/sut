using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;

namespace WebTests
{
    internal class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static string BaseAddress { get { return ConstantsUtils.Url;  } }

        internal static void Initialize()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");
            options.AddArgument("--no-sandbox");
            options.AddArgument("--disable-dev-shm-usage");
            options.AddArgument("--window-size=1400,1400");
            //Instance = new ChromeDriver(options);

            Instance = new RemoteWebDriver(new Uri("http://server:4444/wd/hub"), options.ToCapabilities());
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