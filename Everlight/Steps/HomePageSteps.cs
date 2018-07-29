using Everlight.Steps;
using Everlight.Util;
using EverlightLib;
using EverlightLib.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Everlight
{
    [Binding]
    public class HomePageSteps  
    {
        private Context _context;


        public HomePageSteps(Context context)
        {
            this._context = context;
        }
     
        [Given(@"I Navigate to Home page")]
        public void GivenINavigateToHomePage()
        {
            
            
        }
        [When(@"I Enter search Term (.*)")]
        public void WhenIEnterSearchTerm(string searchTerm)
        {
            _context.homepage.EnterFilterText(searchTerm);
        }

     
        
        [When(@"I click on Filter Button")]
        public void WhenIClickOnFilterButton()
        {
           _context.homepage.SearchSubmit();
        }
        
     

        [Then(@"Computer List is filtred with (.*)")]
        public void ThenComputerListIsFiltredWith(string p0)
        {
            Assert.IsTrue(_context.homepage.CheckFilteredTable(p0.Trim()));
        }

        [Then(@"Number of Filtred Computers are displayed Correctly")]
        public void ThenNumberOfFiltredComputersAreDisplayedCorrectly()
        {
            Assert.AreEqual(1,_context.homepage.GetFiltredRecordCount(), "Result count differ");
        }


    }
}
