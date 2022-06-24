
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;

namespace SampleAutomation
{
    public class Driver
    {
        protected IWebDriver myDriver;
        public static bool isInitialized = false;

        public Driver(IWebDriver driver)
        {
            this.myDriver = driver;
        }

        public IWebDriver Initialize(string browserName, FirefoxDriver driver)
        {
            if (browserName.Equals("firefox"))

            {

                
                
               
                new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());

                driver = new FirefoxDriver();

                driver.Manage().Window.Maximize();
                isInitialized = true;
            }

            return driver;
        }

        public void StartURL(IWebDriver myDriver,string item)
        {

            myDriver.Navigate().GoToUrl(item);
          // return new LoginPage(myDriver);
        }
        public void Finalize(IWebDriver myDriver)
        {
            isInitialized = false;
            myDriver.Close();
            myDriver.Quit();
        }
    }
}
