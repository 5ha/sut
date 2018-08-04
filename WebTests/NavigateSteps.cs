using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace WebTests
{
    [Binding]
    public class NavigateSteps
    {
        [BeforeScenario]
        public void Setup()
        {
            Driver.Initialize();
            Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress);
        }

        [AfterScenario]
        public void TearDown()
        {
            Driver.Close();
        }

        [Given(@"the specflow page")]
        public void GivenTheSpecflowPage()
        {

        }
        
        [When(@"I press Specflow\+")]
        public void WhenIPressSpecflow()
        {
            NavigateToSpecFlowExcel.ClickSpecflowPlus();
        }
        
        [When(@"Specflow\+-Excel")]
        public void WhenSpecflow_Excel()
        {
            NavigateToSpecFlowExcel.ClickSpecflowPlusExcel();
        }
        
        [Then(@"I'(.*)'Get Started Now with SpecFlow\+ Excel!' button")]
        public void ThenIGetStartedNowWithSpecFlowExcelButton(string p0)
        {
            Assert.AreEqual(ConstantsUtils.GetStartedExcelButtonText, NavigateToSpecFlowExcel.GetButtonGetStartedText());
        }
    }
}
