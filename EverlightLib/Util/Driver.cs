using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

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
            /*Headless Magic  */
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");
            Instance = new ChromeDriver(chromeOptions);
           
        //    Instance = new ChromeDriver();
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