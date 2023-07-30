using Milestone4specflow.Drivers;
using Milestone4specflow.Screenshot;
using Milestone4specflow.Utility;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Milestone4specflow.POM
{
    class WebsitesMethod
    {
        public static void NavigateURL()
        {
            DriverMethod.driver.Manage().Window.Maximize();
            DriverMethod.driver.Navigate().GoToUrl(Spreadsheet.excelRead(1, 1));
            lognet.log.Info("NavigateURL");
        }
        public static void Searchbox()
        {
            Thread.Sleep(2000);
            DriverMethod.driver.FindElement(By.XPath("//button[@class='o-navbar-label js-search-btn']")).Click();
            lognet.log.Info("Searchbox");
        }
        public static void TypeShampooSearch()
        {
            Thread.Sleep(2000);
            IWebElement  Shampoo = DriverMethod.driver.FindElement(By.XPath("//*[@id='inlineSearch']/div/span/input"));
            Shampoo.SendKeys(Spreadsheet.excelRead(2,1));
            Shampoo.SendKeys(Keys.Enter);
            lognet.log.Info("TypeShampooSearch");
        }
        public static void Searchresults()
        {
            string text = DriverMethod.driver.FindElement(By.XPath("//h2[contains(text(),'Shampoo')]")).Text;
            Thread.Sleep(2000);
            Assert.That(text,Is.EqualTo("Shampoo"));         
            lognet.log.Info("Searchresults");
        }
        public static void givencapture()
        {
            Thread.Sleep(2000);
            CaputreImage.Cp("Search capture");
            lognet.log.Info("givencapture");
        }
    }

}
