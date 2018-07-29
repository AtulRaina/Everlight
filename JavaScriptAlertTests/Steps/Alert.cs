using Everlight.Util;
using JavascriptAlerts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace JavaScriptAlertTests
{
    [Binding]
    public class AlertSteps: Start
    {

        AlertHomePage alertHomepage;
        [Given(@"I am on Java Script Alert page")]
        public void GivenIAmOnJavaScriptAlertPage()
        {
            alertHomepage = new AlertHomePage(Instance);
            Assert.AreEqual("https://the-internet.herokuapp.com/javascript_alerts", alertHomepage.GetCurrentPageUrl(), "Failed to Navigate to Home page");
        }

        [Given(@"I click on Alert Button")]
        public void GivenIClickOnAlertButton()
        {
            alertHomepage.ClickButton();
        }
        [Given(@"I click on JsComfirmButton")]
        public void GivenIClickOnJsComfirmButton()
        {
            alertHomepage.ClickJsConfirmButton();
        }


        [When(@"I click Ok Button In Alert Window")]
        public void WhenIClickOkButtonInAlertWindow()
        {

     
            alertHomepage.AlertClickOk();
        }

        [Then(@"Message (.*) is displayed")]
        public void ThenMessageIsDisplayed(string p0)
        {
            Assert.AreEqual(p0, alertHomepage.GetResultText(), "Click on Alert Failed");
        }

        [Given(@"I click on JsPromptButton")]
        public void GivenIClickOnJsPromptButton()
        {
            alertHomepage.ClickJsPromptButton();
        }

        [Given(@"I send Text (.*)")]
        public void GivenISendText(string p0)










        {
            alertHomepage.EnterTextInAlert(p0);
        }


    }
}
