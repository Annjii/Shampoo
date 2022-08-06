using Milestone4specflow.Drivers;
using Milestone4specflow.Hooks;
using Milestone4specflow.Screenshot;
using Milestone4specflow.Utility;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Milestone4specflow.POM
{
    class StopTheBeautyTestMethod
    {
        public static IJavaScriptExecutor js;
        public static void NavigateURL()
        {
            DriverMethod.driver.Manage().Window.Maximize();
            DriverMethod.driver.Navigate().GoToUrl(Spreadsheet.excelRead(1, 1));
            lognet.log.Info("NavigateURL");
        }
        public  static void Scrolltonavigate()
        {
            js = (IJavaScriptExecutor)DriverMethod.driver;
            Thread.Sleep(2000);
            int locationY_OfElement = DriverMethod.driver.FindElement(By.XPath("//*[@id='hero - c62e182cbd703ee6278e6f740a321bfb']/div/div[3]/div/div/div/div/div[1]/h1")).Location.Y;
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0, " + locationY_OfElement + ")");
            lognet.log.Info("Scrolltonavigate");
        }
        public static void Clickondiscover()
        {
            Thread.Sleep(2000);
            DriverMethod.driver.FindElement(By.XPath("//*[@id='home - story - ']/div/ul/li[1]/div/div/div[2]/a")).Click();
            lognet.log.Info("discover");
        }
        public static void verifyLetsStopTheBeautyTest()
        {
            string text = DriverMethod.driver.FindElement(By.XPath("//*[@id='hero-cb82492a9ef184edc027f9fd0503877']/div/div[3]/div/div/div/div/div/h1")).Text;
            Thread.Sleep(2000);
            Assert.That(text, Is.EqualTo("StopTheBeautyTest"));
            lognet.log.Info("LetsStopTheBeautyTest");
        }
        public static void StopTheBeautycapture()
        {
            Thread.Sleep(2000);
            CaputreImage.Cp("Search capture");
            lognet.log.Info("StopTheBeautycapture");
        }
    }
}
