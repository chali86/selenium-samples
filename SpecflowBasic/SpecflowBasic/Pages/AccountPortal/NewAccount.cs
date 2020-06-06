using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SpecflowBasic.Utilities;
using System;

namespace SpecflowBasic.Pages.AccountPortal
{
    class NewAccount
    {
        Excel readExcelReader = new Excel();
        private IWebDriver _driver;

        String storedaccID;

        [FindsBy(How = How.Name, Using = "cusid")]
        [CacheLookup]
        public IWebElement cusid { get; set; }

        [FindsBy(How = How.Name, Using = "selaccount")]
        [CacheLookup]
        public IWebElement accountType { get; set; }

        [FindsBy(How = How.Name, Using = "inideposit")]
        [CacheLookup]
        public IWebElement depositAmount { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='addAccount.php']")]
        [CacheLookup]
        public IWebElement newAccount { get; set; }

        [FindsBy(How = How.Name, Using = "button2")]
        [CacheLookup]
        public IWebElement submit { get; set; }

        [FindsBy(How = How.XPath, Using = "//tr[4]/td[2]")]
        [CacheLookup]
        public IWebElement AccID { get; set; }

        public NewAccount(IWebDriver _driver)
        {
            this._driver = _driver;
            PageFactory.InitElements(_driver, this);
        }
        public void clickNewAccount()
        {
            newAccount.Click();
        }

        public void newAccountDetails()
        {
            cusid.SendKeys(readExcelReader.readExcel("\\data.xlsx", 2, 1, 2));
            accountType.SendKeys(readExcelReader.readExcel("\\data.xlsx", 2, 2, 2));
            depositAmount.SendKeys((readExcelReader.readExcel("\\data.xlsx", 2, 3, 2)));
            submit.Click();


        }

        public void StoreAccountID()
        {
            storedaccID = AccID.Text;
            readExcelReader.writeExcel("\\data.xlsx", 2, 2, 4, storedaccID);
        }
    }
}

