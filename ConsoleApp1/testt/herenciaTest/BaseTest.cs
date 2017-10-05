using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.testt.herenciaTest
{
    class BaseTest
    {

        public IWebDriver driver = null;

        [SetUp]
        public void Initilize()
        {
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\Users\mdalessio\Desktop", "geckodriver.exe");
            driver = new FirefoxDriver(service);
        }
        [TearDown]
        public void EndTest()
        {

            driver.Quit();
        }


    }
}
