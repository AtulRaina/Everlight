using EverlightLib.Util;
using TechTalk.SpecFlow;

namespace JavaScriptAlertTests.Hooks1
{
    [Binding]
    public sealed class Hooks1 : Driver
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            Intitialize();
            Instance.Navigate().GoToUrl(JavaBaseAddress);
            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
            Close();
        }
    }
}