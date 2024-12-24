using System;
using System.Xml.Linq;
using AngleSharp.Css.Dom;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace SpecFlowProject_BDD.StepDefinitions
{
    [Binding]
    public class BankProjectStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver;
        public BankProjectStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;
        }

        [Given(@"User is on the bank web page")]
        public void GivenUserIsOnTheBankWebPage()
        {
            _driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/BankingProject/#/login");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [When(@"User clicks on the bank manager login button")]
        public void WhenUserClicksOnTheBankManagerLoginButton()
        {
           _driver.FindElement(By.XPath("//button[normalize-space()='Bank Manager Login']")).Click();
        }

        [Given(@"User finds the Add Customer tab")]
        public void GivenUserFindsTheAddCustomerTab()
        {
            IWebElement addCustomerTab = _driver.FindElement(By.XPath("//button[normalize-space()='Add Customer']"));
            if (addCustomerTab.Displayed)
            {
                Console.WriteLine("Add Customer tab is displayed");
            }
            else
            {
                Console.WriteLine("Add Customer tab is not displayed");
            }
        }

        [When(@"User clicks on the Add Customer tab")]
        public void WhenUserClicksOnTheAddCustomerTab()
        {
            _driver.FindElement(By.XPath("//button[normalize-space()='Add Customer']")).Click();
            Thread.Sleep(2000);
        }

        [When(@"User enters the ""([^""]*)"" ""([^""]*)"" ""([^""]*)"" details")]
        public void WhenUserEntersTheDetails(string prasad, string poojary, string p2)
        {
            _driver.FindElement(By.XPath("//input[@placeholder='First Name']")).SendKeys("John");
            _driver.FindElement(By.XPath("//input[@placeholder='Last Name']")).SendKeys("Doe");
            _driver.FindElement(By.XPath("//input[@placeholder='Post Code']")).SendKeys("12345");
            Thread.Sleep(2000);
        }

        [When(@"User clicks on Add Customer")]
        public void WhenUserClicksOnAddCustomer()
        {
            _driver.FindElement(By.XPath("//button[normalize-space()='Add Customer']")).Click();
            Thread.Sleep(2000);
        }

        [Then(@"User gets the confirmation popup")]
        public void ThenUserGetsTheConfirmationPopup()
        {
            IAlert alert = _driver.SwitchTo().Alert();
            alert.Accept();
            Thread.Sleep(2000);
        }

        [Given(@"User finds the Open Account tab")]
        public void GivenUserFindsTheOpenAccountTab()
        {
            IWebElement openAccount = _driver.FindElement(By.XPath("//button[normalize-space()='Open Account']"));
            if (openAccount.Displayed)
            {
                Console.WriteLine("Open Account tab is displayed");
            }
            else
            {
                Console.WriteLine("Open Account tab is not displayed");
            }
        }

        [When(@"User clicks on the Open Account tab")]
        public void WhenUserClicksOnTheOpenAccountTab()
        {
            _driver.FindElement(By.XPath("//button[normalize-space()='Open Account']")).Click();
            Thread.Sleep(2000);
        }

        [When(@"User selects the recently added customer from the dropdown list")]
        public void WhenUserSelectsTheRecentlyAddedCustomerFromTheDropdownList()
        {
            var dropdown = new SelectElement(_driver.FindElement(By.XPath("//select[@id='userSelect']")));
            dropdown.SelectByText("John Doe");
        }   
            
        [When(@"User selects the currency type")]
        public void WhenUserSelectsTheCurrencyType()
        {
            var dropdown = new SelectElement(_driver.FindElement(By.XPath("//select[@id='currency']")));
            dropdown.SelectByText("Rupee");
        }

        [When(@"User clicks on the Process button")]
        public void WhenUserClicksOnTheProcessButton()
        {
           _driver.FindElement(By.XPath("//button[normalize-space()='Process']")).Click();
            Thread.Sleep(2000);
        }

        [Given(@"User finds the Customers button")]
        public void GivenUserFindsTheCustomersButton()
        {
            IWebElement customers = _driver.FindElement(By.XPath("//button[normalize-space()='Customers']"));
            if (customers.Displayed)
            {
                Console.WriteLine("customers tab is displayed");
            }
            else
            {
                Console.WriteLine("customers tab is not displayed");
            }
        }

        [When(@"User clicks on the Customers tab")]
        public void WhenUserClicksOnTheCustomersTab()
        {
            _driver.FindElement(By.XPath("//button[normalize-space()='Customers']")).Click();
            Thread.Sleep(2000);
        }

        [When(@"User enters the recently added customer in the search box")]
        public void WhenUserEntersTheRecentlyAddedCustomerInTheSearchBox()
        {
           _driver.FindElement(By.XPath("//input[@placeholder='Search Customer']")).SendKeys("John Doe");
            Thread.Sleep(2000);
        }

        [Then(@"User gets the ""([^""]*)"" details")]
        public void ThenUserGetsTheDetails(string name)
        {
            IWebElement element = _driver.FindElement(By.XPath("//td[normalize-space()='" + name + "']/../td[5]//button[contains(text(),'Delete')]"));
            if (element.Displayed)
            {
                Console.WriteLine("Account details are displayed");
            }
            else
            {
                Console.WriteLine("Account details are not displayed");
            }
        }

        [Then(@"User deletes the ""([^""]*)""")]
        public void ThenUserDeletesThe(string name)
        {
            _driver.FindElement(By.XPath("//td[normalize-space()='"+name+"']/../td[5]//button[contains(text(),'Delete')]")).Click();
            Thread.Sleep(2000);
        }
    }
}
