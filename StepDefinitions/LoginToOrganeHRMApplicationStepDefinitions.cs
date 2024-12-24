using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject_BDD.StepDefinitions
{
    [Binding]
    public class LoginToOrganeHRMApplicationStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver;

        public LoginToOrganeHRMApplicationStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;
        }

        [Given(@"User is on the login page")]
        public void GivenUserIsOnTheLoginPage()
        {
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [When(@"User enters valid username and password")]
        public void WhenUserEntersValidUsernameAndPassword()
        {
            _driver.FindElement(By.XPath("//input[@placeholder='Username']")).SendKeys("Admin");
            Thread.Sleep(2000);
            _driver.FindElement(By.XPath("//input[@placeholder='Password']")).SendKeys("admin123");
            Thread.Sleep(2000);
        }

        [When(@"User clicks on the login button")]
        public void WhenUserClicksOnTheLoginButton()
        {
            _driver.FindElement(By.TagName("button")).Click();
            Thread.Sleep(10000);
        }

        [Then(@"User is navigated to home page")]
        public void ThenUserIsNavigatedToHomePage()
        {
            Console.WriteLine("User is navigated to home page");
        }
    }
}
