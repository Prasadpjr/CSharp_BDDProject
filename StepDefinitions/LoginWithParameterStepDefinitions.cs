using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlowProject_BDD.StepDefinitions
{
    [Binding]
    public class LoginWithParameterStepDefinitions
    {      
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver;

        public LoginWithParameterStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;
        }

        [Given(@"User is on the login to page")]
        public void GivenUserIsOnTheLoginPage()
        {
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [When(@"User enters valid ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserEntersValidUsernameAndPassword(string username, string password)
        {
            _driver.FindElement(By.XPath("//input[@placeholder='Username']")).SendKeys(username);
            Thread.Sleep(2000);
            _driver.FindElement(By.XPath("//input[@placeholder='Password']")).SendKeys(password);
            Thread.Sleep(2000);
        }

        [When(@"User click on the login button")]
        public void WhenUserClicksOnTheLoginButton()
        {
            _driver.FindElement(By.TagName("button")).Click();
            Thread.Sleep(10000);
        }

        [Then(@"User navigated to home page")]
        public void ThenUserIsNavigatedToHomePage()
        {
            Console.WriteLine("User is navigated to home page");
        }

        //second step definitions for scenario outline --copied and pasted from the feature file step definitions
        [When(@"User enter the ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserEnterTheAnd(string username, string password)
        {
         Console.WriteLine("Username is: " + username + " and Password is: " + password);
        }

        [Then(@"User selects city and country information")]
        public void ThenUserSelectsCityAndCountryInformation(Table table)
        {
            foreach(var row in table.Rows)
            {
                string city = row["city"];
                string country = row["country"];
                Console.WriteLine("City is: " + city + " and Country is: " + country);
            }
        }

    }
}
