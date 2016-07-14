using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;

namespace TestFramework
{
    public static class Pages
    {
        public static HomePage HomePage
        {
            get
            {
                var homePage = new HomePage();
                PageFactory.InitElements(Browser.Driver, homePage);
                return homePage;
            }
        }

        public static MonthPage MonthPage
        {
            get
            {
                var monthPage = new MonthPage();
                PageFactory.InitElements(Browser.Driver, monthPage);
                return monthPage;
            }
        }

    }
}
