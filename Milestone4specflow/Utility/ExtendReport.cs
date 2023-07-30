using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using Milestone4specflow.Utility;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Milestone4specflow.Utility
{
    class ExtendReport
    {
        public static ExtentReports extent;
        public static ExtentTest test;
        public static ExtentTest feature;
        public static ExtentTest scenario;


        public static void generateReport()
        {
            var htmlRepoter = new ExtentHtmlReporter(@"C:\Users\mindc1may266\Desktop\M1089290 Milestone 4\Milestone4specflow\Milestone4specflow\\Index.html");
            htmlRepoter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            extent = new ExtentReports();
            extent.AttachReporter(htmlRepoter);
            lognet.log.Info("generateReport");

        }
        public static void flushReport()
        {
            extent.Flush();
            lognet.log.Info("flushReport");
        }
        public static void featureReport()
        {
            feature = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
        }

        public static void scenarioReport()
        {
            scenario = feature.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
        }

        public static void scenarioStepReport()
        {
            if (ScenarioContext.Current.TestError == null)
            {
                var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
            }
            if (ScenarioContext.Current.TestError != null)
            {
                var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
            }
        }
    }
}
