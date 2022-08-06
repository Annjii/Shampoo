using OpenQA.Selenium;
using Milestone4specflow.Drivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Milestone4specflow.Screenshot
{
    class CaputreImage
    {
        public static void Cp(String SShottest)
        {
            ((ITakesScreenshot)DriverMethod.driver).GetScreenshot().SaveAsFile(@"C:\Users\mindc1may266\Desktop\M1089290Milestone4\Milestone4specflow\Milestone4specflow\Screenshot\" + SShottest + ".Png");
        }
    }
}
