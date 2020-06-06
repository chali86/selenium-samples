using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SpecflowBasic.Utilities;
using System;

namespace SpecflowBasic.Pages.CustomerPortal
{
    class AddNewCustomer
    {
        Excel readExcelReader = new Excel();

        private IWebDriver _driver;
        String _storedcusID;

        [FindsBy(How = How.Name, Using = "name")]
        [CacheLookup]
        public IWebElement cusname { get; set; }

        [FindsBy(How = How.Name, Using = "rad1")]
        [CacheLookup]
        public IWebElement gender { get; set; }

        [FindsBy(How = How.Id, Using = "dob")]
        [CacheLookup]
        public IWebElement dob { get; set; }

        [FindsBy(How = How.Name, Using = "addr")]
        [CacheLookup]
        public IWebElement address { get; set; }

        [FindsBy(How = How.Name, Using = "city")]
        [CacheLookup]
        public IWebElement city { get; set; }

        [FindsBy(How = How.Name, Using = "state")]
        [CacheLookup]
        public IWebElement state { get; set; }

        [FindsBy(How = How.Name, Using = "pinno")]
        [CacheLookup]
        public IWebElement pinno { get; set; }

        [FindsBy(How = How.Name, Using = "telephoneno")]
        [CacheLookup]
        public IWebElement mobileno { get; set; }

        [FindsBy(How = How.Name, Using = "emailid")]
        [CacheLookup]
        public IWebElement emailid { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        [CacheLookup]
        public IWebElement password { get; set; }

        [FindsBy(How = How.Name, Using = "sub")]
        [CacheLookup]
        public IWebElement submitButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='addcustomerpage.php']")]
        [CacheLookup]
        public IWebElement register { get; set; }

        [FindsBy(How = How.XPath, Using = "//tr[4]/td[2]")]
        [CacheLookup]
        public IWebElement CusID { get; set; }

        public AddNewCustomer(IWebDriver _driver)
        {
            this._driver = _driver;
            PageFactory.InitElements(_driver, this);
        }
        public void clickNewUserREgister()
        {
            register.Click();
        }
        

        public void newCustomerdetails()
        {
            cusname.SendKeys(readExcelReader.readExcel("\\data.xlsx", 1, 4, 2));
            gender.Click();
            dob.SendKeys((readExcelReader.readExcel("\\data.xlsx", 1, 5, 2)));
            address.SendKeys((readExcelReader.readExcel("\\data.xlsx", 1, 6, 2)));
            city.SendKeys((readExcelReader.readExcel("\\data.xlsx", 1, 7, 2)));
            state.SendKeys((readExcelReader.readExcel("\\data.xlsx", 1, 8, 2)));
            pinno.SendKeys((readExcelReader.readExcel("\\data.xlsx", 1, 9, 2)));
            mobileno.SendKeys((readExcelReader.readExcel("\\data.xlsx", 1, 10, 2)));
            emailid.SendKeys((readExcelReader.readExcel("\\data.xlsx", 1, 11, 2)));
            password.SendKeys((readExcelReader.readExcel("\\data.xlsx", 1, 12, 2)));
        }

        public void Submit()
        {
            submitButton.Click();

        }

        public void StoreCustomerID()
        {
            _storedcusID = CusID.Text;
            readExcelReader.writeExcel(@"C:\Users\chs\source\repos\BDDBankProject\data.xlsx", 2, 2, 1, _storedcusID);
        }
    }

}
