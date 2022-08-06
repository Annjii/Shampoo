using System;
using TechTalk.SpecFlow;

namespace milestone4.Features
{
    [Binding]
    public class ShampooStepsDefinition
    {
        [Given(@"Navigate to Url")]
        public void GivenNavigateToUrl()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Type Shampoo in Search box and hit enter")]
        public void WhenTypeShampooInSearchBoxAndHitEnter()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Verify the Search results")]
        public void WhenVerifyTheSearchResults()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Check if First Search result Matches to given Screenshot")]
        public void WhenCheckIfFirstSearchResultMatchesToGivenScreenshot()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Click on Search box")]
        public void ThenClickOnSearchBox()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
