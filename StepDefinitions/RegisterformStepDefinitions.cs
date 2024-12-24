using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlowProject_BDD.StepDefinitions
{
    [Binding]
    public class RegisterformStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver;
        public RegisterformStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;
        }

        [Given(@"user is on the registration page")]
        public void GivenUserIsOnTheRegistrationPage()
        {
            _driver.Navigate().GoToUrl("https://rahulshettyacademy.com/angularpractice/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(4000);
        }

        //Approach 1
        /*
        [When(@"user enters the following details")]
         public void WhenUserEntersTheFollowingDetails(Table table)
         {
             foreach (var row in table.Rows) {
                 _driver.FindElement(By.XPath("(//input[@name='name'])[1]")).SendKeys(row["Name"]);
                 Thread.Sleep(1000);
                 _driver.FindElement(By.XPath("//input[@name='email']")).SendKeys(row["EmailAddress"]);
                 Thread.Sleep(1000);
                 _driver.FindElement(By.Id("exampleInputPassword1")).SendKeys(row["Password"]);
                 Thread.Sleep(1000);
                 _driver.FindElement(By.TagName("select")).SendKeys(row["Gender"]);
                 Thread.Sleep(1000);
                 _driver.FindElement(By.XPath("//input[@name='bday']")).SendKeys(row["dateofbirth"]);
                 Thread.Sleep(1000); */

        //Approach 2
      

        [When(@"user enters the ""([^""]*)"" ""([^""]*)"" ""([^""]*)"" ""([^""]*)"" ""([^""]*)"" details")]
        public void WhenUserEntersTheDetails(string name, string emailAddress, string password, string gender, string dateofbirth)
      

        {
            _driver.FindElement(By.XPath("(//input[@name='name'])[1]")).SendKeys(name);
                Thread.Sleep(1000);
                _driver.FindElement(By.XPath("//input[@name='email']")).SendKeys(emailAddress);
                Thread.Sleep(1000);
                _driver.FindElement(By.Id("exampleInputPassword1")).SendKeys(password);
                Thread.Sleep(1000);
                _driver.FindElement(By.TagName("select")).SendKeys(gender);
                Thread.Sleep(1000);
                _driver.FindElement(By.XPath("//input[@name='bday']")).SendKeys(dateofbirth);
                Thread.Sleep(1000);

        }
        

        [Then(@"fomrs filled successfully")]
        public void ThenFomrsFilledSuccessfully()
        {
           Console.WriteLine("Form filled successfully");
        }
    }
}
