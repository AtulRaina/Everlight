using Everlight.Util;
using EverlightLib;
using EverlightLib.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Everlight
{
    [Binding]
    public class DeleteComputerSteps : Start
    {
        private HomePage hompepage;
        private AddNewComputer addNewComputer;
        private NewComputer newComputer;

        [Given(@"I am on home page and I select a computer with (.*)")]
        public void GivenIAmOnHomePageAndISelectAComputerWith(string p0)
        {
            addNewComputer = new AddNewComputer(Instance);
            hompepage.SelectComputerwithNameFilter(p0);
        }

        [Given(@"I am at home page")]
        public void GivenIAmAtHomePage()
        {
            hompepage = new HomePage(Instance);
            addNewComputer = new AddNewComputer(Instance);
        }

        [Given(@"A computer with name (.*) exist")]
        public void GivenAComputerWithNameExist(string p0)
        {
            CrudHelpers.AddComputer(hompepage, addNewComputer, p0);
        }

        [Given(@"I Filter computer with (.*)")]
        public void GivenIFilterComputerWith(string p0)
        {
            newComputer = new NewComputer();
            newComputer.Name = p0;

            hompepage.EnterFilterText(p0);
            hompepage.SearchSubmit();
        }

        [Given(@"I select the computer")]
        public void GivenISelectTheComputer()
        {
            hompepage.SelectComputerwithNameFilter(newComputer.Name);
        }

        [When(@"I Click Delete")]
        public void WhenIClickDelete()
        {
            addNewComputer.DeleteComputer();
        }

        [Then(@"the computer is deleted")]
        public void ThenTheComputerIsDeleted()
        {
            Assert.AreEqual("Done! Computer has been deleted", addNewComputer.GetComputerAddedMessage());
        }
    }
}