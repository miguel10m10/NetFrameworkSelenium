using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using RelevantCodes.ExtentReports;
using System.Configuration;

namespace ConsoleApp1.testt.herenciaTest
{
    class BaseTest : ExtentBase
    {
   
        public IWebDriver driver = null;

        [SetUp]
        public void Initilize()
        {

            string pathProject = AppDomain.CurrentDomain.BaseDirectory;
            string pathDriver = pathProject.Replace("\\bin\\Debug", "");

            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(pathDriver, "drivers/win/geckodriver.exe");
            driver = new FirefoxDriver(service);
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URL"]);

        }
        [TearDown]
        public void EndTest()
        {
            driver.Quit();
        }
    }
}
