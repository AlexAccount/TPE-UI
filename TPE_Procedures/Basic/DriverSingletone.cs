using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Internal;

namespace TPE_ProceduresUI.Basic
{
    public class DriverSingletone
    {
        public static RemoteWebDriver Chrome_Driver;
        private const string serverUrl = "http://127.0.0.1:4723/wd/hub";
        //protected static AppiumDriver<AppiumWebElement>  Chrome_Driver;

        public static RemoteWebDriver getDriver()
        {
            if (Chrome_Driver == null)
            {
                #region Chrome Options

                #region Obsolete Capabilities
                //DesiredCapabilities cap = new DesiredCapabilities();
                //    cap.SetCapability("deviceName", "Lenovo TB-X340L");
                //    cap.SetCapability("platformVersion", "7.1.1");
                //    cap.SetCapability(MobileCapabilityType.BrowserName, "Chrome");
                //    cap.SetCapability("platformName", "Android");
                //Chrome_Driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);
                #endregion

                ChromeOptions opts = new ChromeOptions();
                    opts.AddAdditionalCapability("deviceName", "Lenovo TB-X340L", true);
                    opts.AddAdditionalCapability("platformVersion", "7.1.1", true);
                    opts.PlatformName = "Android";
                
                    Chrome_Driver = new RemoteWebDriver (new Uri(serverUrl), opts.ToCapabilities(), TimeSpan.FromSeconds(150000));
                
                    Chrome_Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(150);
                    Chrome_Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(150);
               
                
                #region Atempt for Displayed method
                //ChromeOptions opts = new ChromeOptions();
                //Uri serverUri = new Uri("http://127.0.0.1:4723/wd/hub");
                //opts.AddAdditionalCapability("deviceName", "Lenovo TB-X340L", true);
                //opts.AddAdditionalCapability("platformVersion", "7.1.1", true);
                //opts.PlatformName = "Android";
                //Chrome_Driver = new AndroidDriver<AndroidElement>(serverUri, opts.ToCapabilities(), TimeSpan.FromSeconds(200));
                #endregion

                #endregion

                #region If the app is tested
                //cap.SetCapability("udid", "");
                //cap.SetCapability("fullReset", "true");
                #endregion

            }
            return Chrome_Driver;
        }

              
        public static void closeCurrentDriver(AppiumDriver<AndroidElement> CurrentDriver)
        {
            if (CurrentDriver != null)
            {
                CurrentDriver.Quit();
                CurrentDriver = null;
            }


            if (Chrome_Driver != null)
            {
                Chrome_Driver.Quit();
                Chrome_Driver = null;
            }
            //else if (driverFF != null)
            //{
            //    driverFF.Quit();
            //    driverFF = null;
            //}

            //else if (driverMobile != null)
            //{
            //    driverMobile.Quit();
            //    driverMobile = null;
            //}

        }

    }
}
