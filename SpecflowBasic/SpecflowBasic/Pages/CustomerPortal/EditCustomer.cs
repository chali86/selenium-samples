using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SpecflowBasic.Utilities;


namespace SpecflowBasic.Pages.CustomerPortal
{
    class EditCustomer
    {
        Excel readExcelReader = new Excel();

        private IWebDriver _driver;

        [FindsBy(How = How.Name, Using = "name")]
        [CacheLookup]
        public IWebElement cusname { get; set; }

        [FindsBy(How = How.Name, Using = "gender")]
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

        [FindsBy(How = How.XPath, Using = "//a[@href='EditCustomer.php']")]
        [CacheLookup]
        public IWebElement edit { get; set; }

        public EditCustomer(IWebDriver _driver)
        {
            this._driver = _driver;
            PageFactory.InitElements(_driver, this);
        }
        public void clickNewUserEdit()
        {
            edit.Click();
        }


        public void editCustomerdetails()
        {
            address.Clear();
            city.Clear();
            state.Clear();
            pinno.Clear();
            mobileno.Clear();
            emailid.Clear();

            address.SendKeys((readExcelReader.readExcel("\\data.xlsx", 3, 3, 2)));
            city.SendKeys((readExcelReader.readExcel("\\data.xlsx", 3, 4, 2)));
            state.SendKeys((readExcelReader.readExcel("\\data.xlsx", 3, 5, 2)));
            pinno.SendKeys((readExcelReader.readExcel("\\data.xlsx", 3, 6, 2)));
            mobileno.SendKeys((readExcelReader.readExcel("\\data.xlsx", 3, 7, 2)));
            emailid.SendKeys((readExcelReader.readExcel("\\data.xlsx", 3, 8, 2)));


        }
        public void Submit()
        {
            submitButton.Click();

        }
    }
}
