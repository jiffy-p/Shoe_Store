using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestFramework
{
    public class MonthPage
    {
        private static string PageTitle = "Shoe Store: January's Shoes";

        public bool IsAt()
        {
            var monthPage = new MonthPage();
            PageFactory.InitElements(Browser.Driver, monthPage);
            return Browser.Title == PageTitle;
        }

        public bool ShoeDescriptionsAreVisible()
        {
            var shoeDescriptions = Browser.Driver.FindElements(By.CssSelector("#shoe_list .shoe_description"));
            return shoeDescriptions.All(description => description.Displayed);
        }

        public bool ShoeImagesAreVisible()
        {
            var shoeImages = Browser.Driver.FindElements(By.CssSelector("#shoe_list .shoe_image img"));
            return shoeImages.All(image => image.Displayed);
        }

        public bool ShoePricesAreVisible()
        {
            var shoePrices = Browser.Driver.FindElements(By.CssSelector("#shoe_list .shoe_price"));
            return shoePrices.All(price => price.Displayed);
        }

    }
}