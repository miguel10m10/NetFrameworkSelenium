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
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1.testt.herenciaTest
{
    class BaseTest
    {

        public IWebDriver driver = null;

        [SetUp]
        public void Initilize()
        {
            /*var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
			var iconPath = Path.Combine(outPutDirectory, "geckodriver");
			string icon_path = new Uri(iconPath).LocalPath;*/
            



			FirefoxDriverService service = FirefoxDriverService.CreateDefaultService("/Users/miguel/NetFrameworkSelenium/ConsoleApp1/drivers/mac/", "geckodriver");
            driver = new FirefoxDriver(service);
        }
        [TearDown]
        public void EndTest()
        {

            driver.Quit();
        }


    }
}
