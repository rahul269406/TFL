using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;

namespace Demo.UIElements
{
    public class JourneyPage
    {
        public IWebDriver WebDriver { get; }
        public JourneyPage(IWebDriver webDriver)
        {
           WebDriver  = webDriver;

        }

        public IWebElement planJourneyTab => WebDriver.FindElement(By.XPath("//*[@id='mainnav']/div[2]/div/div[2]/ul/li[1]/a"));
        public IWebElement from => WebDriver.FindElement(By.Id("InputFrom"));
        public IWebElement to => WebDriver.FindElement(By.Id("InputTo"));
        public IWebElement planJourneyBtn => WebDriver.FindElement(By.Id("plan-journey-button"));
        public IWebElement AcceptCookies => WebDriver.FindElement(By.Id("CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll"));
        public IWebElement okbtn => WebDriver.FindElement(By.XPath("//*[@id='cb-confirmedSettings']/div[2]/button"));
        public IWebElement IsValidJoureny => WebDriver.FindElement(By.XPath("//*[contains(text(),'We found more than one location matching')]"));
        public IWebElement IsInValidJoureny => WebDriver.FindElement(By.XPath("//*[contains(text(),'Sorry, we can')]"));

        public IWebElement EditLink => WebDriver.FindElement(By.LinkText("Edit journey"));
        public IWebElement Recenttab => WebDriver.FindElement(By.Id("jp-recent-tab-jp"));
        public IList<IWebElement> RecenttabContent => WebDriver.FindElements(By.XPath("//*[@id='jp-recent-content-jp-']/a"));


        public int VerifyRecenttabContent()
        {
            return RecenttabContent.Count;
        }

        public void clickRecenttab()
        {
            Recenttab.Click();
        }

        public void clickEditLink()
        {
            EditLink.Click();
        }

        public bool displayIsValidJoureny()
        {
            
            try
            {
                return IsValidJoureny.Displayed;
            }
            catch(NoSuchElementException e)
            {
                return false;
            }
        }

        public bool displayIsInValidJoureny()
        {
            try
            {
                return IsValidJoureny.Displayed;

            }
            catch(NoSuchElementException e)
            {
                return false;
            }




        }



        public void clickplanJourneyTab()
        {
            planJourneyTab.Click();
        }

        public void sendFrom(string fromvalaue)
        {
            from.SendKeys(fromvalaue);
            from.SendKeys(Keys.Tab);



        }

        public void sendTo(string toValue)
        {
            to.SendKeys(toValue);
            to.SendKeys(Keys.Tab);
        }

        public void clickplanJourneyBtn()
        {
            planJourneyBtn.Click();
        }
        public void clickAcceptCookies()
        {
            AcceptCookies.Click();
        }
        public void clickOkbutton()
        {
            okbtn.Click();
        }
    }
}
