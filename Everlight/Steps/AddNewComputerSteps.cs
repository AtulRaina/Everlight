using Everlight.Util;
using EverlightLib;
using EverlightLib.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Everlight
{
    [Binding]
    public class AddNewComputerSteps : Start
    {
        private HomePage hompepage;
        private AddNewComputer addNewComputer;
        private NewComputer newComputer;
        private NewComputer computerdetails;
        //private Context _context;

        [Given(@"I am on home page")]
        public void GivenIAmOnHomePage()
        {
            hompepage = new HomePage(Instance);
            addNewComputer = new AddNewComputer(Instance);
        }

        [Given(@"I click Add New Computer")]
        [When(@"I click Add New Computer")]
        public void WhenIClickAddNewComputer()
        {
            hompepage.ClickAddComputer();
        }

        [Then(@"Computer name text box is selected")]
        public void ThenComputerNameTextBoxIsSelected()
        {
            Assert.IsTrue(addNewComputer.ComputerNameIsSelected(), "Computer name is selected");
        }

        [Then(@"Invalid date text box is higligted")]
        public void ThenInvalidDateTextBoxIsHigligted()
        {
            Assert.IsTrue(addNewComputer.IntroducedDateIsSelected(), "Introduced date is not selected");
        }

        [Then(@"Add new Computer page is displayed")]
        public void ThenAddNewComputerPageIsDisplayed()
        {
            Assert.AreEqual("Add a computer", addNewComputer.GetTitle().Trim(), "Failed to reach New computer Page");
        }

        [Given(@"I add details of computer")]
        public void GivenIAddDetailsOfComputer(Table table)
        {
            newComputer = new NewComputer();
            newComputer = table.CreateInstance<NewComputer>();
            addNewComputer.setComputerName(newComputer.Name);
            addNewComputer.setIntroducredDate(newComputer.IntroducredDate);
            addNewComputer.setDiscontinuedDate(newComputer.DiscontinuedDate);
            addNewComputer.setCompany(newComputer.Company);
        }

        [When(@"I Click Create this Button")]
        public void WhenIClickCreateThisButton()
        {
            addNewComputer.CreateComputer();
        }

        [Then(@"Computer Information is saved correctly")]
        public void ThenComputerInformationIsSavedCorrectly()
        {
            computerdetails = CrudHelpers.GetComputer(hompepage, addNewComputer, newComputer.Name);
            CrudHelpers.DelteComputer(hompepage, addNewComputer, newComputer.Name);
            //  Assert.IsTrue(Object.Equals(computerdetails,newComputer), "Computer Information is not saved correctly");
            Assert.IsTrue(computerdetails.Name == newComputer.Name, "Name is not saved correctly");
            Assert.IsTrue(computerdetails.IntroducredDate == newComputer.IntroducredDate, "Introduced date is not saved correctly");
            Assert.IsTrue(computerdetails.DiscontinuedDate == newComputer.DiscontinuedDate, "Discontinued date is not saved correctly");
            Assert.IsTrue(computerdetails.Company == newComputer.Company, "Company Name is not saved correctly");
        }

        [Then(@"New Computer is added")]
        public void ThenNewComputerIsAdded()
        {// Have to fix this method
            Assert.IsTrue(addNewComputer.GetComputerAddedMessage().Contains(newComputer.Name), "Computer Name is not added");
            // make sure to clean the clutter
            CrudHelpers.DelteComputer(hompepage, addNewComputer, newComputer.Name);
        }

        [Then(@"Message with Text (.*) is displayed")]
        public void ThenMessageWithTextIsDisplayed(string p0)
        {
            string myexpected = p0.Trim();
            string actualFromPage = addNewComputer.EmptyNameMessage().Trim();
            Assert.AreEqual(myexpected, actualFromPage, "Required Field is missing");
        }
    }
}