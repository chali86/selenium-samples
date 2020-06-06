using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SpecflowBasic.Utilities;

namespace SpecflowBasic.Pages.AccountPortal
{
    class DepositMoney
    {
        Excel readExcelReader = new Excel();
        private IWebDriver _driver;

        [FindsBy(How = How.Name, Using = "accountno")]
        [CacheLookup]
        public IWebElement accountno { get; set; }

        [FindsBy(How = How.Name, Using = "ammount")]
        [CacheLookup]
        public IWebElement amount { get; set; }

        [FindsBy(How = How.Name, Using = "desc")]
        [CacheLookup]
        public IWebElement description { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='DepositInput.php']")]
        [CacheLookup]
        public IWebElement deposit { get; set; }

        [FindsBy(How = How.Name, Using = "AccSubmit")]
        [CacheLookup]
        public IWebElement submit { get; set; }

        public DepositMoney(IWebDriver _driver)
        {
            this._driver = _driver;
            PageFactory.InitElements(_driver, this);
        }
        public void clickdeposit()
        {
            deposit.Click();
        }

        public void depositdetails()
        {
            accountno.SendKeys(readExcelReader.readExcel("\\data.xlsx", 2, 4, 2));
            amount.SendKeys(readExcelReader.readExcel("\\data.xlsx", 2, 5, 2));
            description.SendKeys((readExcelReader.readExcel("\\data.xlsx", 2, 6, 2)));
            submit.Click();


        }
    }
}
