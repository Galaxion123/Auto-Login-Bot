using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Auto_Login_Bot
{
    public class Program
    {
        static void Main()
        {
            IWebDriver driverGC = new ChromeDriver();

            const string _url = "https://lk-ofd.taxcom.ru/";

            const string usr = "";
            const string pass = "";

            driverGC.Navigate().GoToUrl(_url);
            IWebElement Login = driverGC.FindElement(By.Id("authorization-email-input"));
            IWebElement Password = driverGC.FindElement(By.Id("authorization-password-input"));
            IWebElement LoginButton = driverGC.FindElement(By.Id("authorization-submit-button"));
            Login.SendKeys(usr);
            Password.SendKeys(pass);
            LoginButton.Click();
        }
    }
}
