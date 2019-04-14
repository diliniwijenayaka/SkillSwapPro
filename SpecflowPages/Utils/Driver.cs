using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowPages
{
    public class Driver
    {
        internal static object webDriver;

        //Initialize the browser
        public static IWebDriver WebDriver { get; set; }

        //public static void Initialize()
        //{
            //Defining the browser
            //WebDriver = new ChromeDriver();
            //TurnOnWait();

        public static void DriverInitialize(string browser)
        {
            switch (browser)
            {
                case "Chrome":
                    webDriver = new ChromeDriver();
                    break;
            //    case "IE":
            //        webDriver = new InternetExplorerDriver();
            //        break;
            //    case "Firefox":
            //        webDriver = new FirefoxDriver();
            //        break;
            }

            //Maximise the window
            WebDriver.Manage().Window.Maximize();

        }

        public static string BaseUrl
        {
            get{ return ConstantUtils.Url; }
        }
           
        
        //Implicit Wait
        public static void TurnOnWait()
        {
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }

        //Navigate to Website URL
        public static void NavigateUrl(string url)
        {
            WebDriver.Navigate().GoToUrl(url);
        }


        //Close the browser
        public static void Close()
        {
            WebDriver.Close();
        }

    }
}
