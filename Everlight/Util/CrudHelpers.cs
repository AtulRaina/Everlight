using EverlightLib;
using EverlightLib.Pages;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Everlight.Util
{
    public static class CrudHelpers
    {
        public static void AddComputer(HomePage homepage, AddNewComputer addNewComputer, string name)
        {
            homepage.ClickAddComputer();
            addNewComputer.setComputerName(name);
            addNewComputer.setIntroducredDate("1902-12-12");
            addNewComputer.setDiscontinuedDate("1902-12-12");
            addNewComputer.setCompany("Amazon");
            addNewComputer.CreateComputer();
        }

        public static void DelteComputer(HomePage homepage, AddNewComputer addNewComputer, string name)
        {
            homepage.EnterFilterText(name);
            homepage.SearchSubmit();
            homepage.SelectComputerwithNameFilter(name);
            addNewComputer.DeleteComputer();
        }

        internal static NewComputer GetComputer(HomePage hompepage, AddNewComputer addNewComputer, string name)
        {
            NewComputer updatedComputer = new NewComputer();
            Dictionary<string, string> temp = new Dictionary<string, string>();
            hompepage.EnterFilterText(name);
            hompepage.SearchSubmit();
            updatedComputer = new NewComputer();

            temp = hompepage.GetComputerInformation(name);
            updatedComputer.Company = temp["Comp"];
            updatedComputer.Name = temp["ComputerName"];
            updatedComputer.IntroducredDate = temp["Intro"].Length > 1 ? DateChanger(temp["Intro"]) : "";
            updatedComputer.DiscontinuedDate = temp["Dis"].Length > 1 ? DateChanger(temp["Dis"]) : "";

            return updatedComputer;
        }

        //Format date from 
        private static string DateChanger(string sourceDate)
        {
            DateTime temp = DateTime.ParseExact(sourceDate, "dd MMM yyyy", CultureInfo.InvariantCulture);
            string str = temp.ToString("yyyy-MM-dd");
            return str;
        }
    }
}