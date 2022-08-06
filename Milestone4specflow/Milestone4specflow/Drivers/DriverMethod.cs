using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using Milestone4specflow.Utility;

namespace Milestone4specflow.Drivers
{
    class DriverMethod
    {
        public static IWebDriver driver;

        public static void InitializeDriver()
        {
            driver = new ChromeDriver(@"C:\Users\mindc1may266\Downloads\chromedriver_win32");
            lognet.log.Info("InitializeDriver");

        }
        public static void closeDriver()
        {
            driver.Close();
            lognet.log.Info("closeDriver");

        }
    }
}
