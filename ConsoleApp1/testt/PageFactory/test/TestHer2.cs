﻿using NUnit.Framework;
using OnlineStore.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;

namespace ConsoleApp1.testt.herenciaTest
{
    class TestHer2 : BaseTest
    {
        [Test]
        public void TestPF2()
        {
            test = extent.StartTest("PassTest2");
            test.Log(LogStatus.Info, "START");


            var homePage = new HomePage(this.driver);
            PageFactory.InitElements(driver, homePage);
            homePage.ClickOnMyAccount();
            test.Log(LogStatus.Info, "Click homePage");

            var loginPage = new LoginPage(this.driver);
            PageFactory.InitElements(driver, loginPage);
            loginPage.LoginToApplication("miguel10m", "miguel20");
        }
    }
}
