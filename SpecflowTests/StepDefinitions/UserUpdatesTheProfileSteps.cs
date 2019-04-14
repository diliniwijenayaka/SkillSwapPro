using TechTalk.SpecFlow;
using OpenQA.Selenium;
using SpecflowPages;
using SpecflowPages.Pages;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecflowTests.StepDefinitions
{
    //Background steps to login to the application
    [Binding]
    public class UserUpdatesTheProfileSteps
    {
        [Given(@"User is using ""(.*)"" browser")]
        public void GivenUserIsUsingBrowser(string browser)
        {
            Driver.DriverInitialize(browser);
        }

        [When(@"User navifgates to ""(.*)"" url")]
        public void WhenUserNavifgatesToUrl(string url)
        {
            Driver.WebDriver.Navigate().GoToUrl(url);
        }
        
        [When(@"User enters valid login credentials ""(.*)"" and ""(.*)""")]
        public void WhenUserEntersValidLoginCredentialsAnd(string username, string password)
        {
            LoginPage LoginObject = new LoginPage();
            LoginObject.LoginSteps(username, password);
        }

        [Then(@"User is able to Login")]
        public void ThenUserIsAbleToLogin()
        {
            Driver.TurnOnWait();

            //by using assertion
            IWebElement element = Driver.WebDriver.FindElement(By.XPath("//*[@class='item']/button"));
            Assert.IsTrue(element.Displayed);
            Assert.IsTrue(element.Text.Contains("Sign Out"));

        }

        //Background Steps End

        //Add a new language to the profile
        [Given(@"User clicked on the '(.*)' tab under Profile page")]
        public void WhenUserAddsANewLanguageSpanishAndBasic(string Language)
        {
            ProfilePage languageObject = new ProfilePage();
            languageObject.clickMenuOptions(Language); ;
        }

        [Given(@"User click on Add New button for '(.*)'")]
        public void GivenUserClickOnAddNewButtonFor(string addNew)
        {
            ProfilePage languageObject = new ProfilePage();
            languageObject.clickAddnew(addNew);
        }

        [When(@"User is able to add a new entry for Language with values (.*) and (.*)")]
        public void WhenUserIsAbleToAddANewEntryForLanguageWithValuesAnd(string Language, string level)
        {
            ProfilePage languageObject = new ProfilePage();
            languageObject.addNewLanguage(Language, level);

        }

        [Then(@"that (.*) language should be added to user profile")]
        public void ThenThatLanguageShouldBeAddedToUserProfile(string Language)
        {
            ProfilePage languageObject = new ProfilePage();
            languageObject.rowPresent(Language);
        }

        //Delet a Language
        [When(@"User is able to delete Language with values (.*)")]
        public void WhenUserIsAbleToDeleteLanguageWithValues(string Language)
        {
            ProfilePage languageObject = new ProfilePage();
            languageObject.deleteLanguage(Language);
        }

        [Then(@"that (.*) language should not be visible on the Language page")]
        public void ThenThatLanguageShouldNotBeVisibleOnTheLanguagePage(string Language)
        {
            ProfilePage languageObject = new ProfilePage();
            languageObject.languageDeletedConfirm(Language);
        }

        //Add a new skill to the profile
        [When(@"User add a new skill (.*) and (.*)")]
        public void WhenUserAddANewSkillAnd(string skill, string skillLevel)
        {
            ProfilePage skillObject = new ProfilePage();
            skillObject.AddNewSkill(skill, skillLevel);
        }

        [Then(@"that (.*) skill should be added to user profile")]
        public void ThenThatSkillShouldBeAddedToUserProfile(string skill)
        {
            ProfilePage skillObject = new ProfilePage();
            skillObject.rowSkillPresent(skill);
        }

        //Add a new Education to the Profile
        [When(@"User add a Education (.*), (.*),(.*),(.*) and (.*)")]
        public void WhenUserAddAEducationAnd(string college, string country, string title, string degree, string year)
        {
            ProfilePage educationObject = new ProfilePage();
            educationObject.addNewEducation(college, country, title, degree, year);
        }

        [Then(@"that (.*),(.*) education should be added to user profile")]
        public void ThenThatEducationShouldBeAddedToUserProfile(string college, string country)
        {
            ProfilePage educationObject = new ProfilePage();
            educationObject.rowEducationPresent(college, country);

        }

        //Add a new Certificate to the Profile
        [When(@"User add a new (.*), (.*) and (.*)")]
        public void WhenUserAddANewAnd(string certificate, string certificateFrom, string year)
        {
            ProfilePage certificateObject = new ProfilePage();
            certificateObject.addNewCertificate(certificate, certificateFrom, year);
        }

        //[Then(@"that (.*) certificate should be added to user profile")]
        //public void ThenThatCertificateShouldBeAddedToUserProfile(string certificate)
        //{
        //    ProfilePage certificateObject = new ProfilePage();
        //    certificateObject.rowCertificatePresent(certificate);
        //}

        [When(@"User update the Language information Fluent")]
        public void WhenUserUpdateTheLanguageInformationFluent()
        {
            ScenarioContext.Current.Pending();
        }        
    }
}
