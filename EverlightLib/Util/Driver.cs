using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EverlightLib.Util
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static string BaseAddress
        {
            get { return ConstantsUtils.Url; }
        }

        public static string JavaBaseAddress
        {
            get { return ConstantsUtils.AlertsUrl; }
        }
        public static void Intitialize()
        {
            Instance = new ChromeDriver();
            TurnOnWait();
            Instance.Manage().Window.Maximize();
        }

        public static void Navigate()
        {
            Instance.Navigate().GoToUrl(BaseAddress);
        }

        public static void Close()
        {
            Instance.Close();
        }

        private static void TurnOnWait()
        {
            // Instance.Manage().Timeouts().ImplicitWait(TimeSpan.FromSeconds(5));
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
    }
}