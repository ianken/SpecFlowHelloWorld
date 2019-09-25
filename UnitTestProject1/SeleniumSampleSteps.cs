using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
    [Binding]
    public class SeleniumSampleSteps
    {
        IWebDriver driver;

        [Given(@"Chrome is running")]
        public void GivenChromeIsRunning()
        {
            driver = new ChromeDriver(@"C:\");
        }
        
        [Given(@"I have navigated to (.*)")]
        public void GivenIHaveNavigatedToBing_Com(string target)
        {
            driver.Navigate().GoToUrl(target);
        }
        
        [Then(@"verify website destiantion (.*)")]
        public void ThenVerifyWebsiteLoaded(string target)
        {
            //This doesn't actually verify anything...
            Assert.AreEqual(driver.Url, target);
            driver.Quit();
        }
    }
}
