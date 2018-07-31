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

        [FindsBy(How = How.CssSelector, Using = "#main > form > fieldset > div.clearfix.error > div > span")]
        private IWebElement addComputerNameRequireMessage;

        public bool ComputerNameIsSelected()
        {
            return addComputerName.Enabled;
        }

        public bool IntroducedDateIsSelected()
        {
            return addComputerIntroduced.Enabled;
        }

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
            addComputerName.Clear();
            addComputerName.SendKeys(name);
        }

        public void setIntroducredDate(string introducredDate)
        {
            addComputerIntroduced.Clear();
            addComputerIntroduced.SendKeys(introducredDate);
        }

        public void CreateComputer()
        {
            addComputerCreate.Click();
        }

        public string EmptyNameMessage()
        {
            string text = addComputerNameRequireMessage.Text;
            return text;
        }

        public void setDiscontinuedDate(string discontinuedDate)
        {
            addComputerDiscontinued.Clear();
            addComputerDiscontinued.SendKeys(discontinuedDate);
        }

        public void setCompany(string company)
        {
            addComputerCompany.SendKeys(company);
        }
    }
}