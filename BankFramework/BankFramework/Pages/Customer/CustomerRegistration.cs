using OpenQA.Selenium;
using SpecflowBasic.Utilities;
using System;


namespace BankFramework.Pages.Customer
{
	class CustomerRegistration
	{
		Excel readExcelReader = new Excel();
		readonly IWebDriver _driver;
		private readonly By _loginID = By.Name("uid");
		private readonly By _password = By.Name("password");
		private readonly By _loginButton = By.Name("btnLogin");
	}
}
