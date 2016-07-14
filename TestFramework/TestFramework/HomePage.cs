using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestFramework
{
    public class HomePage
    {
        private static string Url = "http://shoestore-manheim.rhcloud.com/";
        private static string PageTitle = "Shoe Store: Welcome to the Shoe Store";

        public void Goto()
        {
            Browser.Goto(Url);
        }

        public bool IsAt()
        {
            return Browser.Title == PageTitle;
        }

        public void SelectMonth(string monthName)
        {
            var monthLink = new WebDriverWait(Browser.Driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists(By.LinkText(monthName)));
            monthLink.Click();
        }

        public bool EmailReminderFieldIsVisible()
        {
            return new WebDriverWait(Browser.Driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists(By.Id("remind_email_input"))).Displayed;

        }

        public void SubmitReminderEmailAddress(string emailAddress)
        {
            var emailAddressField = new WebDriverWait(Browser.Driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists(By.Id("remind_email_input")));
            emailAddressField.SendKeys(emailAddress);
            var submitButton = new WebDriverWait(Browser.Driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists(By.CssSelector("input[type='submit']")));
            submitButton.Click();
        }

        public bool EmailConfirmationMessageIsVisible(string emailAddress)
        {
            
            var confirmationMessage = new WebDriverWait(Browser.Driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists(By.CssSelector("#flash>div")));
            return confirmationMessage.Text ==
                   "Thanks! We will notify you of our new shoes at this email: " + emailAddress && confirmationMessage.Displayed;
        }
    }
}