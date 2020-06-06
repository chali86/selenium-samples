using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SpecflowBasic.Utilities;

namespace SpecflowBasic.Pages.CustomerPortal
{
    class SearchCustomer
    {
        Excel readExcelReader = new Excel();
        private IWebDriver _driver;

        [FindsBy(How = How.Name, Using = "cusid")]
        [CacheLookup]
        public IWebElement cusid { get; set; }

        [FindsBy(How = How.Name, Using = "AccSubmit")]
        [CacheLookup]
        public IWebElement submit { get; set; }

        public SearchCustomer(IWebDriver _driver)
        {
            this._driver = _driver;
            PageFactory.InitElements(_driver, this);
        }


        public void SearchCustomerDetails()
        {
            cusid.SendKeys(readExcelReader.readExcel("\\data.xlsx", 2, 1, 2));

            submit.Click();


        }
    }
}
