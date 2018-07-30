using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EverlightLib.Pages
{
    public class AddNewComputer
    {
        private IWebDriver driver;

        public AddNewComputer(IWebDriver driver)
        {
            // this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#main > h1")]
        private IWebElement addComputerTitle;

        // classname
        ////*[@id="main"]/div[1]
        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div[1]")]
        private IWebElement addComputerSuccessMessage;

        //name
        [FindsBy(How = How.Id, Using = "name")]
        private IWebElement addComputerName;

        [FindsBy(How = How.Id, Using = "introduced")]
        private IWebElement addComputerIntroduced;

        [FindsBy(How = How.Id, Using = "discontinued")]
        private IWebElement addComputerDiscontinued;

        [FindsBy(How = How.Id, Using = "company")]
        private IWebElement addComputerCompany;

        [FindsBy(How = How.CssSelector, Using = "#main > form > div > input")]
        private IWebElement addComputerCreate;

        [FindsBy(How = How.CssSelector, Using = "#main > form.topRight > input")]
        private IWebElement deleteComputer;

        //#main > form:nth-child(2) > div > input

        [FindsBy(How = How.CssSelector, Using = "#main > form:nth-child(2) > div > input")]
        private IWebElement updateComputer;

        public void DeleteComputer()
        {
            deleteComputer.Click();
        }

        public void UpdateComputer()
        {
            updateComputer.Click();
        }

        public string GetTitle()
        {
            return addComputerTitle.Text;
        }

        public string GetComputerAddedMessage()
        {
            string text = addComputerSuccessMessage.Text;
            return text;
        }

        public void setComputerName(string name)
        {
            addComputerName.SendKeys(name);
        }

        public void setIntroducredDate(string introducredDate)
        {
            addComputerIntroduced.SendKeys(introducredDate);
        }

        public void CreateComputer()
        {
            addComputerCreate.Click();
        }

        public void setDiscontinuedDate(string discontinuedDate)
        {
            addComputerDiscontinued.SendKeys(discontinuedDate);
        }

        public void setCompany(string company)
        {
            addComputerCompany.SendKeys(company);

            //electElement(browser.FindElement(By.CssSelector("#Menu_ParentMenuID"))).SelectBySubText("item1")

            // addComputerCompany.FindElement(By.XPath(".//option[contains(text(),'OptionText')]")).Click();
        }
    }
}