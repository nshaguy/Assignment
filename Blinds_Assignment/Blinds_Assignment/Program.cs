using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blinds_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver webDriver = new ChromeDriver();
            //Access Google
            webDriver.Navigate().GoToUrl("http://www.google.com");
            webDriver.Url = "http://www.blinds.com";
            //Resize the current window to full size
            webDriver.Manage().Window.Size = new System.Drawing.Size(1930, 1024);
            //Thread.Sleep(2000);
            IWebElement search = webDriver.FindElement(By.Id("gcc-inline-search"));
            search.SendKeys("room darkening blinds");
            search.SendKeys(Keys.Enter);
            //Thread.Sleep(2000);
            webDriver.FindElement(By.LinkText("Price Low-High")).Click();
            //Thread.Sleep(2000);
            //webDriver.Close();

        }
    }
}
