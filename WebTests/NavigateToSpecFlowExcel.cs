using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;

namespace WebTests
{
    internal class NavigateToSpecFlowExcel
    {
        internal static void ClickSpecflowPlus()
        {
            var action = new Actions(Driver.Instance);
            var specFlowPlusButton = Driver.Instance.FindElement(By.XPath(".//*[@id='menu-item-701']/a"));
            action.MoveToElement(specFlowPlusButton).Perform();
        }

        internal static void ClickSpecflowPlusExcel()
        {
            var specFlowPlusExcelButton = Driver.Instance.FindElement(By.XPath(".//*[@id='menu-item-698']/a"));
            specFlowPlusExcelButton.Click();
        }

        internal static string GetButtonGetStartedText()
        {
            return Driver.Instance.FindElement(By.XPath(".//*[@id='get-started-now']/a")).Text;
        }
    }
}