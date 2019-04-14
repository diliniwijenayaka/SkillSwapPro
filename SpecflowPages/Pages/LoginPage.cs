using OpenQA.Selenium;
//using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static SpecflowPages.CommonMethods;

namespace SpecflowPages.Pages
{
    public class LoginPage
    {
        public void LoginSteps(string username, string password)
        {
            //Click on Login Link
            Driver.WebDriver.FindElement(By.XPath("//*[@class='ui secondary menu inverted']/div/a")).Click();
            Driver.TurnOnWait();


            Driver.WebDriver.SwitchTo().Window(Driver.WebDriver.WindowHandles.Last());


            //Enter Username
            IWebElement username = Driver.WebDriver.FindElement(By.Name("email"));
            username.Click();
            username.Clear();
            username.SendKeys("username");

            //Enter password
            IWebElement password = Driver.WebDriver.FindElement(By.Name("password"));
            password.Click();
            password.Clear();
            password.SendKeys("password");

            //Click on Login Button
            Driver.WebDriver.FindElement(By.XPath("//*[@class='fluid ui teal button']")).Click();
        }

    }
}
