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
    class LoginTests : DesktopSeleniumTestFixturePrototype
    {
        public LoginTests(Browsers browser) : base(browser)
        { }

        [Test]
        public void LoginTest()
        {
            var loginPageInstance = LoginPage.NavigateTo(base.Driver);

            //loginPageInstance.UserNameTextBox.SendKeys(GeneralSettings.Default.UserName);
            //loginPageInstance.PasswordTextBox.SendKeys(GeneralSettings.Default.Password);

            loginPageInstance.ValidLogIn();

            var yourAccountPage = PageFactoryExtensions.InitPage<YourAccountPage>(this.Driver);

            Thread.Sleep(10000);

            Assert.AreEqual(
                    yourAccountPage.UserNameTextBox.Text, "Nadezhda Georgieva"
                );
        }
    }
}
