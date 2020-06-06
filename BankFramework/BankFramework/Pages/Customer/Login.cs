using OpenQA.Selenium;
using SpecflowBasic.Utilities;
using System;

namespace BankFramework.Pages
{
	class Login
	{
		Excel readExcelReader = new Excel();
		readonly IWebDriver _driver;
		private readonly By _loginID = By.Name("uid");
		private readonly By _password = By.Name("password");
		private readonly By _loginButton = By.Name("btnLogin");

		public Login(IWebDriver _driver)
		{
			this._driver = _driver;

		}

		public void Logindetails()
		{
			try
			{
				_driver.FindElement(_loginID).SendKeys("");
				_driver.FindElement(_password).SendKeys("");
				_driver.FindElement(_loginButton).Click();
			}
			catch (NoSuchElementException e)
			{
				throw new Exception(e.Message);
			}
		}
	}
}




