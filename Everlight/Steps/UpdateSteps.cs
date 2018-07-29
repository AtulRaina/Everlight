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
    public class UpdateSteps: Start
    {

        HomePage hompepage;
        AddNewComputer addNewComputer;
        NewComputer newComputer;
        NewComputer OldComputer;
        NewComputer updatedComputer;



        [Given(@"I select a Computer from Home Page")]
        public void GivenISelectAComputerFromHomePage()
        {
            hompepage = new HomePage(Instance);
            addNewComputer = new AddNewComputer(Instance);
            
        }


        [Given(@"I select Computer with Name (.*)")]
        public void GivenISelectComputerWithName(string p0)
        {
            Dictionary<string, string> temp = new Dictionary<string, string>();
            hompepage.EnterFilterText(p0);
            hompepage.SearchSubmit();
            OldComputer = new NewComputer();
            temp = hompepage.GetComputerInformation(p0);
            OldComputer.Company = temp["ComputerName"];
            OldComputer.Name = temp["Comp"];
            OldComputer.IntroducredDate = temp["Intro"];
            OldComputer.DiscontinuedDate = temp["Disc"];
         
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
            temp = hompepage.GetComputerInformation(newComputer.Name);
             updatedComputer.Company = temp["ComputerName"];
             updatedComputer.Name = temp["Comp"];
             updatedComputer.IntroducredDate = temp["Intro"];
            updatedComputer.DiscontinuedDate = temp["Disc"];
            // this is the comparision of the table 
            Assert.IsTrue(updatedComputer.Equals(newComputer), "Updated Failed for the computer");
        }
    }
}
