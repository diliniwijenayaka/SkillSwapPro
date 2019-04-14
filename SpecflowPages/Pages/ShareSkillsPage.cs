using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpecflowPages.Pages
{
    public class ShareSkillsPage
    {
        //click on the Main Menu links // Click ShareSkill button
        public void clickMainMenuOptions(string menuMainOptions)
        {
            var clickMenu = new ShareSkillsPage();
            var barXpath = "//*[@class='nav-secondary']//a[text()[normalize-space(.)='" + menuMainOptions + "']]";
            IWebElement _menuClickoption = clickMenu.menuBarSkillShareOptions(barXpath);
            _menuClickoption.Click();

        }

        //Function to find menu options 
        public IWebElement menuBarSkillShareOptions(string menuOptionLocator)
        {

            var toolMenu = Driver.WebDriver.FindElement(By.XPath(menuOptionLocator));
            return toolMenu;

        }

        public void clickTitleBox()
        {
            IWebElement titleBox = Driver.WebDriver.FindElement(By.XPath("//*[@name='title']"));
            titleBox.Clear();
            titleBox.Click();
        }

        public void enterDetails(string title, string description, string category, string subCategory, string tags, string serviceType, string locationType, string skilltrade, string skillExchange, string credit, string workSamples, string active)
        {
            //Enter title
            IWebElement titleBox = Driver.WebDriver.FindElement(By.XPath("//*[@name='title']"));
            titleBox.Click();
            titleBox.Clear();
            titleBox.SendKeys(title);

            //Enter Description
            IWebElement descriptionBox = Driver.WebDriver.FindElement(By.XPath("//*[@name='description']"));
            descriptionBox.Click();
            descriptionBox.Clear();
            descriptionBox.SendKeys(title);

            //Select Category
            IWebElement categoryList = Driver.WebDriver.FindElement(By.XPath("//*[@name='categoryId']"));
            IList<IWebElement> optionsCategory = categoryList.FindElements(By.TagName("option"));
            int optionCount = optionsCategory.Count();
            for (int i = 0; i < optionCount; i++)
            {
                if (optionsCategory[i].Text == category)
                {
                    optionsCategory[i].Click();
                }
            }
            //Select Subcategory
            IWebElement subCategoryList = Driver.WebDriver.FindElement(By.XPath("//*[@name='subcategoryId']"));
            IList<IWebElement> optionsSubCategory = subCategoryList.FindElements(By.TagName("option"));
            int optionsSubCategoryCount = optionsSubCategory.Count();
            for (int i = 0; i < optionsSubCategoryCount; i++)
            {
                if (optionsSubCategory[i].Text == subCategory)
                {
                    optionsSubCategory[i].Click();
                }
            }

            //Enter a tag
            IWebElement tagsBox = Driver.WebDriver.FindElement(By.XPath("//*[@class='form-wrapper field  ']/div/div/div/input"));
            tagsBox.Click();
            tagsBox.Clear();
            tagsBox.SendKeys(tags);
            Driver.WebDriver.FindElement(By.XPath("//*[@class='form-wrapper field  ']/div/div/div/input")).SendKeys(Keys.Enter);

            //Select Service Type
            switch (serviceType)
            {
                case "Hourly basis service":

                    var radioST = Driver.WebDriver.FindElement(By.XPath("//*[@class='ui form']/div[5]/div[2]/div[1]/div[1]/div/input"));
                    radioST.Click();
                    break;
                case "One-off service":
                    var radioST2 = Driver.WebDriver.FindElement(By.XPath("//*[@class='ui form']/div[5]/div[2]/div[1]/div[2]/div/input"));
                    radioST2.Click();
                    break;
            }

            //Select Location type
            switch (locationType)
            {
                case "On-site":
                    var radioLT = Driver.WebDriver.FindElement(By.XPath("//*[@class='ui form']/div[6]/div[2]/div/div[1]/div/input"));
                    radioLT.Click();
                    break;
                case "Online":
                    var radioLT2 = Driver.WebDriver.FindElement(By.XPath("//*[@class='ui form']/div[6]/div[2]/div/div[2]/div/input"));
                    radioLT2.Click();
                    break;
            }

            //Select Skill Trade
            switch (skilltrade)
            {
                case "Skill-exchange":
                    var radioST = Driver.WebDriver.FindElement(By.XPath("//*[@class='ui form']/div[8]/div[2]/div/div[1]/div/input"));
                    radioST.Click();
                    //Enter Skill Exchange
                    IWebElement skillExch = Driver.WebDriver.FindElement(By.XPath("//*[@class='field error ']/div/div/div/div/input"));
                    skillExch.Click();
                    skillExch.Clear();
                    skillExch.SendKeys(skillExchange);
                    Driver.WebDriver.FindElement(By.XPath("//*[@class='field error ']/div/div/div/div/input")).SendKeys(Keys.Enter);
                    break;
                case "Credit":
                    var radioST2 = Driver.WebDriver.FindElement(By.XPath("//*[@class='ui form']/div[8]/div[2]/div/div[2]/div/input"));
                    radioST2.Click();
                    IWebElement creditEnter = Driver.WebDriver.FindElement(By.XPath("//*[@name='charge']"));
                    creditEnter.Click();
                    creditEnter.Clear();
                    creditEnter.SendKeys(credit);

                    break;
            }

            //Upload a work sample
            IWebElement imageUpload = Driver.WebDriver.FindElement(By.XPath("//*[@class='huge plus circle icon padding-25']"));
            imageUpload.Click();
            string filePath = @"C:\\Users\\User\\Desktop\\DILINI" + workSamples + "";
            Process.Start(filePath);

            //Select Active
            switch (active)
            {
                case "Active":
                    var radioA = Driver.WebDriver.FindElement(By.XPath("//*[@class='ui form']/div[10]/div[2]/div/div[1]/div/input"));
                    radioA.Click();
                    break;
                case "Hidden":
                    var radioH = Driver.WebDriver.FindElement(By.XPath("//*[@class='ui form']/div[10]/div[2]/div/div[2]/div/input"));
                    radioH.Click();
                    break;
            }
        }
    }
}
    