﻿using System;
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
using System.Collections;
using OpenQA.Selenium;
using System.Xml;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Appium.Interfaces;

namespace TPE_ProceduresUI.Basic
{
   

    public class BasicMethods
    {
        #region TAGS
        private const string PASSWORD_TAG = "TPEPassword";
        #endregion


        //Need to have better decision when to call logpackage 
        //public static void CreateLog()
        //{
        //    IList successMessage = DriverSingletone.Chrome_Driver.FindElements(By.XPath("//span[contains (text(), 'The procedure has been successfully finished')]"));
        //    if (!Assert.Equals(1, successMessage.Count))
        //    {

        //    }     

        //}

        public static void SwipeCoordinates(IPerformsTouchActions driver, int startX, int startY, int endX, int endY, int duration)
        {
            ITouchAction touchAction = new TouchAction(driver)
                .Press(startX, startY)
                .Wait(duration)
                .MoveTo(endX, endY)
                .Release();

            touchAction.Perform();
        }


        public static void SwipeToElement(IWebElement element)
        {
            ((IJavaScriptExecutor)DriverSingletone.Chrome_Driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        public static string ParseData()
        {
            XmlDocument docParams = new XmlDocument();
            XmlNodeList password;
            docParams.Load("Parameters.xml");
            XmlElement rootElement = docParams.DocumentElement;
            password = rootElement.GetElementsByTagName(PASSWORD_TAG);
            string psw = password[0].InnerText;  

            return psw;
        }

        
        public static void GoTo_TPE()
        {
            DriverSingletone.getDriver();
            DriverSingletone.Chrome_Driver.Navigate().GoToUrl("http://192.168.137.1:8080"); 
        }


        public static void LogOff_TPE()
        {
            IWebElement menuDD = DriverSingletone.Chrome_Driver.FindElement(By.XPath("//div[@id='top-navigation']"));
            menuDD.Click();
            IWebElement LogOutBtn = DriverSingletone.Chrome_Driver.FindElement(By.ClassName("e2e-logout-link"));
            LogOutBtn.Click();
        }

        public static void CheckElementExistance(int i, IList element, string message)
        {
            Assert.AreEqual(i, element.Count, message + element.ToString());
        }

       
        public static void LogIn_TPE()
        {
            IWebElement pinFieled = DriverSingletone.Chrome_Driver.FindElement(By.Id("login-pass"));
            IWebElement loginBtn = DriverSingletone.Chrome_Driver.FindElement(By.XPath("//button[contains (text(), 'Login')]"));

            pinFieled.SendKeys(ParseData());
            loginBtn.Click();
        }
    }
}
