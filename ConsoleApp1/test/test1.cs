using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace ToolsQA
{
    class test1
    {
        IWebDriver driver = null;




        [SetUp]
        public void Initilize()
        {

            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\Users\mdalessio\Desktop", "geckodriver.exe");
             driver = new FirefoxDriver(service);
        }
        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
        }
        [TearDown]
        public void EndTest()
        {

            driver.Quit();
        }

        
        
    }
}