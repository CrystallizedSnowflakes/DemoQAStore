using NUnit.Framework;
using SeleniumWebDriverTemplateProject.Helpers;
using SeleniumWebDriverTemplateProject.Pages;
using SeleniumWebDriverTemplateProject.Tests.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumWebDriverTemplateProject.Tests
{
    class CheckCurrencyTest : DesktopSeleniumTestFixturePrototype
    {
        public CheckCurrencyTest(Browsers browser) : base(browser)
        { }

        [Test]
        public void IsCurrencyUSDTest()
        {
            var currencyUSDInstance = ProductCategoryPage.NavigateTo(base.Driver);
            var productPrices = currencyUSDInstance.ProductPrices.ToList();

            int count = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < productPrices.Count(); i++)
            {
                char symbolUSD = productPrices[i].Text[0];
               

                if (!symbolUSD.Equals(null) || symbolUSD.Equals('$'))
                {
                    sb.Append($"The symbol is: {symbolUSD}").Append(Environment.NewLine);
                }
                else
                {
                    count++;
                }
              
            }
            Thread.Sleep(6000);

            Assert.AreEqual(productPrices.Count() , count, sb.Length);
        }
    }
}
