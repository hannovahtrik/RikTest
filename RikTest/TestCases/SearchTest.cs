using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace RikTest.TestCases
{
    class SearchTest
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://transport.tallinn.ee/#tallinna-linn/map";

            driver.FindElement(By.CssSelector("input[type='text']")).SendKeys("Tramm number 66");
            bool element = driver.FindElement(By.CssSelector(".stop")).Displayed;
            Assert.IsTrue(element);
            driver.Quit();

        }
    }
}