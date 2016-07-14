using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;

namespace Tests
{
    [TestClass]
    public class Story1Tests
    {
        [TestMethod]
        public void All_Shoe_Descriptions_For_Each_Month_Are_Visible()
        {
            Pages.HomePage.Goto();
            Assert.IsTrue(Pages.HomePage.IsAt()); 
            Pages.HomePage.SelectMonth("January");
            Assert.IsTrue(Pages.MonthPage.IsAt());
            Assert.IsTrue(Pages.MonthPage.ShoeDescriptionsAreVisible());
        }

        [TestMethod]
        public void All_Shoe_Images_For_Each_Month_Are_Visible()
        {
            Pages.HomePage.Goto();
            Assert.IsTrue(Pages.HomePage.IsAt());
            Pages.HomePage.SelectMonth("January");
            Assert.IsTrue(Pages.MonthPage.IsAt());
            Assert.IsTrue(Pages.MonthPage.ShoeImagesAreVisible());

        }

        [TestMethod]
        public void All_Shoe_Suggested_Pricing_For_Each_Month_Are_Visible()
        {
            Pages.HomePage.Goto();
            Assert.IsTrue(Pages.HomePage.IsAt());
            Pages.HomePage.SelectMonth("January");
            Assert.IsTrue(Pages.MonthPage.IsAt());
            Assert.IsTrue(Pages.MonthPage.ShoePricesAreVisible());

        }

        [TestCleanup]
        public void CleanUp()
        {
            Browser.Close();
        }
    }

    [TestClass]
    public class Story2Tests
    {
        [TestMethod]
        public void Email_Reminder_Field_Is_Visible()
        {
            Pages.HomePage.Goto();
            Assert.IsTrue(Pages.HomePage.IsAt());
            Assert.IsTrue(Pages.HomePage.EmailReminderFieldIsVisible());
        }

        [TestMethod]
        public void Can_Register_For_Email_Reminders()
        {
            Pages.HomePage.Goto();
            Assert.IsTrue(Pages.HomePage.IsAt());
            Pages.HomePage.SubmitReminderEmailAddress("test@test.com");
            Assert.IsTrue(Pages.HomePage.EmailConfirmationMessageIsVisible("test@test.com"));

        }

        [TestCleanup]
        public void CleanUp()
        {
            Browser.Close();
        }
    }

}
