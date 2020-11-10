using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace SeleniumTest
{
    class Program
    {
        IWebDriver driver = new ChromeDriver();


        [SetUp]
        public void startBrowser()
        {
            driver.Url = "http://www.google.co.in";
            Thread.Sleep(2000);
        }

        [Test]
        public void test()
        {
            IWebElement ele = driver.FindElement(By.Name("q"));
            ele.SendKeys("anurag patidar");
            Thread.Sleep(2000);
            //identify the google search button  
            IWebElement ele1 = driver.FindElement(By.Name("btnK"));
            // click on the Google search button  
            ele1.Click();
            Thread.Sleep(3000);
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}