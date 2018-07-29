﻿using Everlight.Steps;
using Everlight.Util;
using EverlightLib;
using EverlightLib.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Everlight
{
    [Binding]
    public class AddNewComputerSteps:Start
    {
        HomePage hompepage;
        AddNewComputer addNewComputer;
        NewComputer newComputer;
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

        [Then(@"New Computer is added")]
        public void ThenNewComputerIsAdded()
        {// Have to fix this method
           Assert.IsTrue(addNewComputer.GetComputerAddedMessage().Contains(newComputer.Name), "Computer Name is not added");
        }


    }
}
