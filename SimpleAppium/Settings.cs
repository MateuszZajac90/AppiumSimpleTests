using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;
using System.Threading;
using Assert = NUnit.Framework.Assert;

namespace SimpleAppium
{
    [TestClass]
    public class Settings
    {

        private AndroidDriver<AndroidElement> _driver;
        
        [SetUp]
        public void Setup()
        {

            AppiumOptions driverOptions;

            try
            {
                driverOptions = new AppiumOptions();
                driverOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "mateo");
                driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
                driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "9.0");
                driverOptions.AddAdditionalCapability(MobileCapabilityType.Udid, "emulator-5554");
                driverOptions.AddAdditionalCapability("unicodeKeyboard", "true");
                driverOptions.AddAdditionalCapability("resetKeyboard", "true");
                driverOptions.AddAdditionalCapability("appPackage", "com.android.settings");
                driverOptions.AddAdditionalCapability("appActivity", "com.android.settings.Settings");
                                
                //Launch the Android driver
                _driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub/"), driverOptions);

                //For Native application
                Thread.Sleep(5000);
                _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout[2]/android.support.v7.widget.RecyclerView/android.widget.LinearLayout[2]").Click();
                _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.support.v7.widget.RecyclerView/android.widget.LinearLayout[1]/android.widget.LinearLayout[1]/android.widget.RelativeLayout").Click();
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


    [Test]
        public void WifiSettings()
        {
            try
            {
                Assert.Pass();
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

     
    }
}
