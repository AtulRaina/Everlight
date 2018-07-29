using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support;
using EverlightLib.Util;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;

namespace EverlightLib
{
    // Follow the page object model 
    public class HomePage
    {
//# searchbox
//#searchsubmit
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "searchbox")]
        private IWebElement searchBox;

        [FindsBy(How = How.Id, Using = "searchsubmit")]
        private IWebElement searchSubmit;

        [FindsBy(How = How.TagName, Using = "a")]
        private IList<IWebElement> LI;

        [FindsBy(How = How.CssSelector, Using = "#main > h1")]
        private IWebElement recordCount;
       
        [FindsBy(How = How.Id, Using = "add")]
        private IWebElement addNewComputer;


        public  void EnterFilterText(string computerName)
        {
            searchBox.SendKeys(computerName);
        }

        public void SearchSubmit()
        {
            searchSubmit.Click();
        }

        public void ClickAddComputer()
        {
           addNewComputer.Click();
        }


        public bool CheckFilteredTable(string searchText)
        {
            IWebElement tableElement = driver.FindElement(By.CssSelector("#main > table"));
            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tr"));
            IList<IWebElement> rowTD;
            foreach (IWebElement row in tableRow)
            {
                rowTD = row.FindElements(By.TagName("td"));

                if (rowTD.Count > 0)
                {
                    if (rowTD[0].Text.ToLower().Contains(searchText.ToLower()))
                    {

                    }
                    else
                    {
                        Console.WriteLine(string.Format("The table list has non matching row{0}::",rowTD[0].Text));
                    return false;
                    }
                }
            }

            return true;
        }

        public void SelectComputerwithNameFilter(string Name)
        {
            IWebElement tableElement = driver.FindElement(By.CssSelector("#main > table"));
            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tr"));
            IList<IWebElement> rowTD;
            foreach (IWebElement row in tableRow)
            {
                rowTD = row.FindElements(By.TagName("td"));

                if (rowTD.Count > 0)
                {
                    if (rowTD[0].Text.ToLower().Contains(Name.ToLower()))
                    {
                        string test = rowTD[0].Text;
                        rowTD[0].Click();
                        rowTD[0].Click();

                        rowTD[0].FindElement(By.TagName("a")).Click();
                    
                        
                        //var href = rowTD[0].GetAttribute("Id");
                        //driver.FindElement(By.Id(href)).Click();
                        //Actions actions = new Actions(driver);
                        //actions.MoveToElement(rowTD[0]).Perform();
                      
                        //actions.Click(rowTD[0]).Perform();
                        //       rowTD[0].SendKeys(Keys.Enter);
//# main > table > tbody > tr:nth-child(1) > td:nth-child(1) > a
                        break;
                    }
                   
                }
            }

            
        }


        public Dictionary<string,string> GetComputerInformation(string Name)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            IWebElement tableElement = driver.FindElement(By.CssSelector("#main > table"));
            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tr"));
            IList<IWebElement> rowTD;
            foreach (IWebElement row in tableRow)
            {
                rowTD = row.FindElements(By.TagName("td"));

                if (rowTD.Count > 0)
                {
                    if (rowTD[0].Text.ToLower()==(Name.ToLower()))
                    {

                    dic.Add("ComputerName",rowTD[0].Text);
                    dic.Add("Intro",rowTD[1].Text);
                        dic.Add("Dis", rowTD[2].Text);
                        dic.Add("Comp", rowTD[3].Text);
                        return dic;
                    }

                }
            }
            return dic;
        }


        public bool GetFiltredRecordCount()
        {
            IWebElement tableElement = driver.FindElement(By.CssSelector("#main > table"));
            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tr"));
            string myString = recordCount.Text;
            int count = Convert.ToInt16(myString.Remove(myString.Length - "computers found".Length).Trim());
            
            return count>0;
        }

        
    }
}
