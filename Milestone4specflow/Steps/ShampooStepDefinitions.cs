using Milestone4specflow.POM;
using System;
using TechTalk.SpecFlow;

namespace Milestone4specflow.Steps
{
    [Binding]
    public class ShampooStepDefinitions
    {
        [Given(@"Navigate to Url")]
        public void GivenNavigateToUrl()
        {
            WebsitesMethod.NavigateURL();
        }
        [Then(@"Click on Search box")]
        public void ThenClickOnSearchBox()
        {
            WebsitesMethod.Searchbox();
        }
        [When(@"Type Shampoo in Search box and hit enter")]
        public void WhenTypeShampooInSearchBoxAndHitEnter()
        {
            WebsitesMethod.TypeShampooSearch();
        }

        [When(@"Verify the Search results")]
        public void WhenVerifyTheSearchResults()
        {
            WebsitesMethod.Searchresults();
        }

        [When(@"Check if First Search result Matches to given Screenshot")]
        public void WhenCheckIfFirstSearchResultMatchesToGivenScreenshot()
        {
            WebsitesMethod.givencapture();
        }


        [Given(@"load website")]
        public void GivenLoadWebsite()
        {
            StopTheBeautyTestMethod.NavigateURL();
        }

        [When(@"Scroll to navigate Let's StopTheBeautyTest Section")]
        public void WhenScrollToNavigateLetsStopTheBeautyTestSection()
        {
            StopTheBeautyTestMethod.Scrolltonavigate();
        }

        [Then(@"Click on discover more under Let's StopTheBeautyTest Section")]
        public void ThenClickOnDiscoverMoreUnderLetsStopTheBeautyTestSection()
        {
            StopTheBeautyTestMethod.Clickondiscover();
        }

        [Then(@"check and verify if loaded page shows the real women behind stopthebeauty test option")]
        public void ThenCheckAndVerifyIfLoadedPageShowsTheRealWomenBehindStopthebeautyTestOption()
        {
            StopTheBeautyTestMethod.verifyLetsStopTheBeautyTest();
            StopTheBeautyTestMethod.StopTheBeautycapture();
        }

        [Given(@"load Url in browser")]
        public void GivenLoadUrlInBrowser()
        {
            throw new PendingStepException();
        }

        [When(@"Scroll to footer")]
        public void WhenScrollToFooter()
        {
            throw new PendingStepException();
        }

        [Then(@"click on terms of use")]
        public void ThenClickOnTermsOfUse()
        {
            throw new PendingStepException();
        }

        [Then(@"check and verify if a section with prohibited uses avaiable or not")]
        public void ThenCheckAndVerifyIfASectionWithProhibitedUsesAvaiableOrNot()
        {
            throw new PendingStepException();
        }
    }
}
