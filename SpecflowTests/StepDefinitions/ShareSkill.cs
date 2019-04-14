using System;
using SpecflowPages.Pages;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecflowTests.StepDefinitions
{
    [Binding]
    public class ShareSkill
    {
        [Given(@"User clicked on the '(.*)' button")]
        public void GivenUserClickedOnTheButton(string skillShare)
        {
            ShareSkillsPage shareSkillObject = new ShareSkillsPage();
            shareSkillObject.clickMainMenuOptions(skillShare);
        }

        [When(@"User enter the details (.*), (.*),(.*),(.*),(.*),(.*),(.*), (.*),(.*), (.*) , (.*) , (.*)")]
        public void WhenUserEnterTheDetails(string title, string description, string category, string subCategory, string tags, string serviceType, string locationtype, string skillTrade, string skillExchange, string credit, string workSamples, string active)
        {
            ShareSkillsPage shareSkillObject = new ShareSkillsPage();
            shareSkillObject.enterDetails(title, description, category, subCategory, tags, serviceType, locationtype, skillTrade, skillExchange, credit, workSamples, active);
            Thread.Sleep(10000);
        }

        [When(@"User enter the Available days")]
        public void WhenUserEnterTheAvailableDays()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"that Skill should be added to the Manage Listing page")]
        public void ThenThatSkillShouldBeAddedToTheManageListingPage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
