using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using SeleniumWebDriverTemplateProject.Helpers;
using SeleniumWebDriverTemplateProject.Pages;
using SeleniumWebDriverTemplateProject.Tests.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumWebDriverTemplateProject.Tests
{
    class HomePageTests : DesktopSeleniumTestFixturePrototype
    {
        public HomePageTests(Browsers browser) : base(browser)
        { }

        [Test]
        public void NavigateToHomePageTest()
        {
            var homePageInstance = HomePage.NavigateTo(this.Driver);
            Thread.Sleep(4000);
        }
    }
}
