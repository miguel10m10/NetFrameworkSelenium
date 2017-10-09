using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.testt.herenciaTest
{
    class TestHer1 : BaseTest
    {
        [Test]
        public void Test1675656()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
        }
    }
}
