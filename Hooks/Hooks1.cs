using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using BoDi;
using SpecFlowProject1.Utility;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports;

namespace SpecFlowProject1.Hooks
{
    [Binding]
    public sealed class Hooks1 : ExtentReport

    {
        private readonly IObjectContainer _container;
        public Hooks1(IObjectContainer container)
        {
            _container = container;
        }

        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Console.WriteLine("Running before test run...");
            ExtentReportInit();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Console.WriteLine("Running after test run...");
            ExtentReportTearDown();
        }
        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            Console.WriteLine("Running before feature...");
            _feature = _extentReports.CreateTest<Feature>(featureContext.FeatureInfo.Title);
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            Console.WriteLine("Running after feature...");
        }
        //[AfterStep]
        //public void AfterStep(ScenarioContext scenarioContext)
        //{
        //    Console.WriteLine("Running after step....");
        //    string stepType = scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();
        //    string stepName = scenarioContext.StepContext.StepInfo.Text;

        //    var driver = _container.Resolve<IWebDriver>();

        //    //When scenario passed
        //    if (scenarioContext.TestError == null)
        //    {
        //        if (stepType == "Given")
        //        {
        //            _scenario.CreateNode<Given>(stepName);
        //        }
        //        else if (stepType == "When")
        //        {
        //            _scenario.CreateNode<When>(stepName);
        //        }
        //        else if (stepType == "Then")
        //        {
        //            _scenario.CreateNode<Then>(stepName);
        //        }
        //        else if (stepType == "And")
        //        {
        //            _scenario.CreateNode<And>(stepName);
        //        }
        //    }

        //    }
        }
    } 
