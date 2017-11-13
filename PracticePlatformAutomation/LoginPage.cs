using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformAutomation1
{
    public class LoginPage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("https://dev-platform.authenticateis.com/Account/Logon");
        }

        public static LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
        }
    }

    public class LoginCommand
    {
        private readonly string userName;
        private string password;

        public LoginCommand(string userName)
        {
            this.userName = userName;
        }

        public void Login()
        {
            var loginInput = Driver.Instance.FindElement(By.Id("UserName"));
            loginInput.SendKeys(userName);

            var passwordInput = Driver.Instance.FindElement(By.Id("Password"));
            passwordInput.SendKeys(password);

            var loginButton = Driver.Instance.FindElement(By.Id("do-submit"));
            loginButton.Click();
        }

        public LoginCommand WithPassword(string password)
        {
            this.password = password;
            return this;
        }

    }
}
