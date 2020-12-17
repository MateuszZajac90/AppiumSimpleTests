using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;
using System.Threading;

namespace SimpleAppium
{
    [TestClass]
    public class CalculatorTests
    {

        private AndroidDriver<AndroidElement> _driver;

        private IWebElement one;
        private IWebElement two;
        private IWebElement three;
        private IWebElement four;
        private IWebElement five;
        private IWebElement six;
        private IWebElement seven;
        private IWebElement eight;
        private IWebElement nine;
        private IWebElement divide;
        private IWebElement mal;
        private IWebElement plus;
        private IWebElement minus;
        private IWebElement equals;
        private IWebElement result;
        private IWebElement point;


        [SetUp]
        public void Setup()
        {
            var appPath = @"C:\\Repos\\Appium\\ionic.apk";

            AppiumOptions driverOptions;

            try
            {
                driverOptions = new AppiumOptions();
                driverOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "mateo");
                driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
                driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "9.0");
                driverOptions.AddAdditionalCapability(MobileCapabilityType.Udid, "emulator-5554");
                //driverOptions.AddAdditionalCapability(CapabilityType.BrowserName, "Chrome");
                driverOptions.AddAdditionalCapability("appPackage", "com.android.calculator2");
                driverOptions.AddAdditionalCapability("appActivity", "com.android.calculator2.Calculator");

                //Launch the Android driver

                _driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub/"), driverOptions);

                //For Native application
                Thread.Sleep(5000);
                one = _driver.FindElementById("com.android.calculator2:id/digit_1");
                two = _driver.FindElementById("com.android.calculator2:id/digit_2");
                three =_driver.FindElementById("com.android.calculator2:id/digit_3");
                four = _driver.FindElementById("com.android.calculator2:id/digit_4");
                five = _driver.FindElementById("com.android.calculator2:id/digit_5");
                six = _driver.FindElementById("com.android.calculator2:id/digit_6");
                seven = _driver.FindElementById("com.android.calculator2:id/digit_7");
                eight = _driver.FindElementById("com.android.calculator2:id/digit_8");
                nine = _driver.FindElementById("com.android.calculator2:id/digit_9");
                divide = _driver.FindElementById("com.android.calculator2:id/op_div");
                mal = _driver.FindElementById("com.android.calculator2:id/op_mul");
                plus = _driver.FindElementById("com.android.calculator2:id/op_add");
                minus = _driver.FindElementById("com.android.calculator2:id/op_sub");
                equals = _driver.FindElementById("com.android.calculator2:id/eq");
                result = _driver.FindElementById("com.android.calculator2:id/result");
                point = _driver.FindElementById("com.android.calculator2:id/dec_point");
           

                //For Hybrid applications
                //var contexts = ((IContextAware)_driver).Contexts;
                //string webviewContext = null;
                //for (int i = 0; i < contexts.Count; i++)
                //{
                //    Console.WriteLine(contexts[i]);
                //    if (contexts[i].Contains("WEBVIEW"))
                //    {
                //        webviewContext = contexts[i];
                //    }
                //}

                //((IContextAware)_driver).Context = webviewContext;

                //_driver.FindElementByXPath("//ion-button[text()='Skip']").Click();
                //_driver.FindElementByXPath("//ion-menu-button").Click();
                //_driver.FindElementByXPath("//ion-label[text()=' Login ']").Click();
                //_driver.FindElementByXPath("//ion-input[@ng-reflect-name='username']/input").SendKeys("adminMateo");
                //_driver.FindElementByXPath("//ion-input[@ng-reflect-name='password']/input").SendKeys("ZAQ!2wsx");
                //_driver.HideKeyboard();

                //_driver.FindElementByXPath("//ion-button[text()='Login']").Click();

            }
            catch (Exception exp)
            {
                Console.WriteLine("Error message: ");
                Console.WriteLine(exp.Message);

                Console.WriteLine("Stack trace: ");
                Console.WriteLine(exp.StackTrace);

                Console.WriteLine("Source: ");
                Console.WriteLine(exp.Source); 

                Console.WriteLine("InnerException: ");
                Console.WriteLine(exp.InnerException);

                Console.WriteLine("TargetSite: ");
                Console.WriteLine(exp.TargetSite); 

                Console.WriteLine("Data: ");
                Console.WriteLine(exp.Data); 

                Console.WriteLine("HelpLink: ");
                Console.WriteLine(exp.HelpLink); 

                Console.WriteLine("HResult: ");
                Console.WriteLine(exp.HResult); 

                throw;
            }
        }


    [Test]
        public void SimplePlus()
        {
            try
            {
                one.Click();
                five.Click();
                plus.Click();
                eight.Click();
                equals.Click();

            var resultX = result.Text.ToString();
            NUnit.Framework.Assert.AreEqual(resultX, "23", "Problem with calculation");
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error message: "); Console.WriteLine(exp.Message);
                Console.WriteLine("Stack trace: ");   Console.WriteLine(exp.StackTrace);
                Console.WriteLine("Source: ");        Console.WriteLine(exp.Source);
                Console.WriteLine("InnerException: ");Console.WriteLine(exp.InnerException);
                Console.WriteLine("TargetSite: ");    Console.WriteLine(exp.TargetSite);
                Console.WriteLine("Data: ");          Console.WriteLine(exp.Data);
                Console.WriteLine("HelpLink: ");      Console.WriteLine(exp.HelpLink);
                Console.WriteLine("HResult: ");       Console.WriteLine(exp.HResult);

                throw;
            }

        }

        [Test]
        public void SimpleMinus()
        {
            try
            {
                eight.Click();
                eight.Click();
                minus.Click();
                six.Click();
                six.Click();
                equals.Click();

                var resultX = result.Text.ToString();
                NUnit.Framework.Assert.AreEqual(resultX, "22", "Problem with calculation");
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error message: "); Console.WriteLine(exp.Message);
                Console.WriteLine("Stack trace: "); Console.WriteLine(exp.StackTrace);
                Console.WriteLine("Source: "); Console.WriteLine(exp.Source);
                Console.WriteLine("InnerException: "); Console.WriteLine(exp.InnerException);
                Console.WriteLine("TargetSite: "); Console.WriteLine(exp.TargetSite);
                Console.WriteLine("Data: "); Console.WriteLine(exp.Data);
                Console.WriteLine("HelpLink: "); Console.WriteLine(exp.HelpLink);
                Console.WriteLine("HResult: "); Console.WriteLine(exp.HResult);

                throw;
            }

        }
    }
}
