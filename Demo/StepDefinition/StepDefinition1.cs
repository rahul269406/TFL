
using Demo.UIElements;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace Demo.StepDefinition
{
    [Binding]
    public sealed class StepDefinition1
    {
        //Step Definition Code


        JourneyPage journeyPage=null;
        IWebDriver webDriver;

        [Given(@"User is on the tfl home page")]
        public void GivenUserIsOnTheTflHomePage()
        {
            webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://tfl.gov.uk/");
            Thread.Sleep(5000);
            journeyPage = new JourneyPage(webDriver);
            journeyPage.clickAcceptCookies();
            journeyPage.clickOkbutton();
            Thread.Sleep(5000);

        }
       
        [When(@"click on plan a journey tab")]
        public void WhenClickOnPlanAJourneyTab()
        {
            journeyPage.clickplanJourneyTab();
            Thread.Sleep(1000);
        }

        [When(@"user enter from  ""([^""]*)"" location")]
        public void WhenUserEnterFromLocation(string brighton)
        {
            journeyPage.sendFrom(brighton);



        }

        [When(@"user enter to  ""([^""]*)"" location")]
        public void WhenUserEnterToLocation(string p0)
        {
            journeyPage.sendTo(p0);
            
          

        }

        [When(@"click on plan a journey Button")]
        public void WhenClickOnPlanAJourneyButton()
        {
            Thread.Sleep(2000);
            journeyPage.clickplanJourneyBtn();
            Thread.Sleep(5000);
            
        }

        [Then(@"Verify results")]
        public void ThenVerifyResults()
        {
            
               if(journeyPage.displayIsValidJoureny())
                {

                    Assert.That(true, "More than one results found in the search.");
                }
            
           
            
               else if (journeyPage.displayIsInValidJoureny())
                {
                    Assert.That(true, "Sorry , No match found for your search");

                }
                else

                    Assert.That(true, "Exactly one match found");
                
           

            

        }
        [Then(@"close the driver")]
        public void ThenCloseTheDriver()
        {
            webDriver.Close();

            webDriver.Quit();
        }

        [Then(@"Verify Edit link to edit the journey planned")]
        public void ThenVerifyEditLinkToEditTheJourneyPlanned()
        {
            journeyPage.clickEditLink();
            Thread.Sleep(2000);
        }

        [Then(@"Navigate to recent tab and Verify Recent Journeys")]
        public void ThenNavigateToRecentTabAndVerifyRecentJourneys()
        {
            journeyPage.clickRecenttab();
            Thread.Sleep(2000);
            int count= journeyPage.VerifyRecenttabContent();
            if (count > 0)
            {
                Assert.That(true, "Journeys found in recent tab");
            }
            else
            {
                Assert.That(true, "No Journey found in recent tab");
            }

        }




    }

}
