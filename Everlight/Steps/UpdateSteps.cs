using Everlight.Util;
using EverlightLib;
using EverlightLib.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Everlight
{
    [Binding]
    public class UpdateSteps : Start
    {
        private HomePage hompepage;
        private AddNewComputer addNewComputer;
        private NewComputer newComputer;
        private NewComputer OldComputer;
        private NewComputer updatedComputer;
        private NewComputer computerdetails;

        [Given(@"I select Computer with Name (.*)")]
        public void GivenISelectComputerWithName(string p0)
        {
            Dictionary<string, string> temp = new Dictionary<string, string>();

            hompepage.EnterFilterText(p0);
            hompepage.SearchSubmit();
            OldComputer = new NewComputer();
            OldComputer = CrudHelpers.GetComputer(hompepage, addNewComputer, p0);
            hompepage.SelectComputerwithNameFilter(p0);
        }

        [Given(@"I have Enter the details")]
        public void GivenIHaveEnterTheDetails(Table table)
        {
            newComputer = table.CreateInstance<NewComputer>();
            addNewComputer.setComputerName(newComputer.Name);
            addNewComputer.setIntroducredDate(newComputer.IntroducredDate);
            addNewComputer.setDiscontinuedDate(newComputer.DiscontinuedDate);
            addNewComputer.setCompany(newComputer.Company);
        }

        [Given(@"Computer with name (.*) already exist")]
        public void GivenComputerWithNameAlreadyExist(string p0)
        {
            hompepage = new HomePage(Instance);
            addNewComputer = new AddNewComputer(Instance);
            CrudHelpers.AddComputer(hompepage, addNewComputer, p0);
        }

        [Then(@"I Delete the computer with (.*)")]
        public void ThenIDeleteTheComputerWith(string p0)
        {
            CrudHelpers.DelteComputer(hompepage, addNewComputer, p0);
        }

        [When(@"I click save Computer")]
        public void WhenIClickSaveComputer()
        {
            addNewComputer.UpdateComputer();
        }

        [Then(@"Computer information Is Updated")]
        public void ThenComputerInformationIsUpdated()
        {
            Dictionary<string, string> temp = new Dictionary<string, string>();
            hompepage.EnterFilterText(newComputer.Name);
            hompepage.SearchSubmit();
            updatedComputer = new NewComputer();

            updatedComputer = CrudHelpers.GetComputer(hompepage, addNewComputer, newComputer.Name);

            // this is the comparision of the table
            Console.WriteLine(string.Format("Updated computer name{0}", updatedComputer.Name));
            Console.WriteLine(string.Format("set computer name{0}", newComputer.Name));
            Assert.IsTrue(updatedComputer.Name.Trim() == newComputer.Name.Trim(), "Updated Failed for the computer");
        }

        [Then(@"Computer Name is saved correctly")]
        public void ThenComputerNameIsSavedCorrectly()
        {
            computerdetails = CrudHelpers.GetComputer(hompepage, addNewComputer, newComputer.Name);
            CrudHelpers.DelteComputer(hompepage, addNewComputer, newComputer.Name);
            Assert.IsTrue(computerdetails.Name == newComputer.Name, "Name is not saved correctly");
        }

        [Then(@"Computer Introduced date is saved correctly")]
        public void ThenComputerIntroducedDateIsSavedCorrectly()
        {
            computerdetails = CrudHelpers.GetComputer(hompepage, addNewComputer, newComputer.Name);
            CrudHelpers.DelteComputer(hompepage, addNewComputer, newComputer.Name);

            Assert.IsTrue(computerdetails.IntroducredDate == newComputer.IntroducredDate, "Introduced date is not saved correctly");
        }

        [Then(@"Computer Discontinued Date is saved Correctly")]
        public void ThenComputerDiscontinuedDateIsSavedCorrectly()
        {
            computerdetails = CrudHelpers.GetComputer(hompepage, addNewComputer, newComputer.Name);
            CrudHelpers.DelteComputer(hompepage, addNewComputer, newComputer.Name);
            Assert.IsTrue(computerdetails.DiscontinuedDate == newComputer.DiscontinuedDate, "Discontinued date is not saved correctly");
        }

        [Then(@"Computer Company is saved correctly")]
        public void ThenComputerCompanyIsSavedCorrectly()
        {
            computerdetails = CrudHelpers.GetComputer(hompepage, addNewComputer, newComputer.Name);
            CrudHelpers.DelteComputer(hompepage, addNewComputer, newComputer.Name);
            Assert.IsTrue(computerdetails.Company == newComputer.Company, "Company Name is not saved");
        }
    }
}