using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace JavascriptAlerts
{
    // Follow the page object model
    public class AlertHomePage
    {
        private IWebDriver driver;

        public AlertHomePage(IWebDriver driver)
        {
            this.driver = driver;

            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#content > div > ul > li:nth-child(1) > button")]
        private IWebElement alertButton;

        [FindsBy(How = How.CssSelector, Using = "#content > div > ul > li:nth-child(2) > button")]
        private IWebElement jsConfirmButton;

        [FindsBy(How = How.CssSelector, Using = "#content > div > ul > li:nth-child(3) > button")]
        private IWebElement jsPromptButton;

        [FindsBy(How = How.CssSelector, Using = "#result")]
        private IWebElement resultText;

        //

        public string GetCurrentPageUrl()
        {
            return this.driver.Url;
        }

        public void ClickJsConfirmButton()
        {
            jsConfirmButton.Click();
        }

        public void ClickButton()
        {
            alertButton.Click();
        }

        public void AlertClickOk()
        {
            driver.SwitchTo().Alert().Accept();
        }

        public string GetResultText()
        {
            return resultText.Text;
        }

        public void ClickJsPromptButton()
        {
            jsPromptButton.Click();
        }

        public void EnterTextInAlert(string text)
        {
            var alert = driver.SwitchTo().Alert();
            alert.SendKeys(text.ToString());
        }

        public void AlertClickCancel()
        {
            var alert = driver.SwitchTo().Alert();
            alert.Dismiss();
        }
    }
}