using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SpecflowBasic.Utilities;

namespace SpecflowBasic.Pages.CustomerPortal
{
    class Login
    {
        Excel readExcelReader = new Excel();
        private IWebDriver _driver;

        [FindsBy(How = How.Name, Using = "uid")]
        [CacheLookup]
        public IWebElement loginId { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        [CacheLookup]

        public IWebElement loginPassword { get; set; }

        [FindsBy(How = How.Name, Using = "btnLogin")]
        [CacheLookup]
        public IWebElement loginButton { get; set; }

        public Login(IWebDriver _driver)
        {
            this._driver = _driver;
            PageFactory.InitElements(_driver, this);

        }

        public void Logindetails()
        {
            loginId.SendKeys(readExcelReader.readExcel("\\data.xlsx", 1, 2, 2));
            loginPassword.SendKeys(readExcelReader.readExcel("\\data.xlsx", 1,3, 2));

            loginButton.Click();

        }
    }
}