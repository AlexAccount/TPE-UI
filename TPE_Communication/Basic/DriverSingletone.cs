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

namespace TPE_ProceduresUI.Basic
{
    public class DriverSingletone
    {
        public static AppiumDriver<AndroidElement> Chrome_Driver;

        public static AppiumDriver<AndroidElement> getDriver()
        {
            if (Chrome_Driver == null)
            {
                #region Capabilities
                DesiredCapabilities cap = new DesiredCapabilities();
                cap.SetCapability("deviceName", "Test");
                cap.SetCapability("platformVersion", "7.1.1");
                cap.SetCapability(MobileCapabilityType.BrowserName, "Chrome");
                cap.SetCapability("platformName", "Android");
                Chrome_Driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);
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
