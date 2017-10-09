using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace OnlineStore.PageObjects
{
    class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "account")]
        [CacheLookup]
        public IWebElement MyAccount { get; set; }

        public void ClickOnMyAccount()
        {
            MyAccount.Click();
        }
    }
}
