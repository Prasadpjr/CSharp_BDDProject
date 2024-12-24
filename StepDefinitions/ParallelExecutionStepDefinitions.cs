using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

[assembly: Parallelizable(ParallelScope.All)]
namespace SpecFlowProject_BDD.StepDefinitions
{
    [Binding]
    public class ParallelExecutionStepDefinitions
    {
        [Given(@"User is on the application page on IE browser")]
        public void GivenUserIsOnTheApplicationPageOnIEBrowser()
        {
            Console.WriteLine("User is on the application page on IE browser");
        }

        [Given(@"User is on the application page on Chrome browser")]
        public void GivenUserIsOnTheApplicationPageOnChromeBrowser()
        {
            Console.WriteLine("User is on the application page on Chrome browser");
        }

        [Given(@"User is on the application page on Edge browser")]
        public void GivenUserIsOnTheApplicationPageOnEdgeBrowser()
        {
            Console.WriteLine("User is on the application page on Edge browser");
        }
    }
}
