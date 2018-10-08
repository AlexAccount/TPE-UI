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
using System.Collections;
using OpenQA.Selenium;
using System.Xml;

namespace TPE_ProceduresUI.Basic
{
    public class ElementExists
    {
        #region CheckStepsElements methods
        public static void CheckStepsElements (int i, IList element1, string message)
        {
            Assert.AreEqual(i, element1.Count, "The expected " + message + " does not exist on the page." + 
                                                                           "\nActual result: " + element1.ToString());
        }

        public static void CheckStepsElements(int i, IList element1, IList element2, string message1, string message2)
        {
            Assert.AreEqual(i, element1.Count, "The expected " + message1 + " does not exist on the page." + 
                                                                            "\nActual result: " + element1.ToString());
            Assert.AreEqual(i, element2.Count, "The expected " + message2 + " does not exist on the page." + 
                                                                            "\nActual result: " + element2.ToString());
        }


        public static void CheckStepsElements(int i, IList element1, IList element2, IList element3, string message1, 
                                                                                    string message2, string message3)
        {
            Assert.AreEqual(i, element1.Count, "The expected " + message1 + " does not exist on the page." + 
                                                                            "\nActual result: " + element1.ToString());
            Assert.AreEqual(i, element2.Count, "The expected " + message2 + " does not exist on the page." + 
                                                                            "\nActual result: " + element2.ToString());
            Assert.AreEqual(i, element3.Count, "The expected " + message3 + " does not exist on the page." +
                                                                            "\nActual result: " + element3.ToString());
        }

        public static void CheckStepsElements(int i, IList element1, IList element2, IList element3, IList element4, 
                                                 string message1, string message2, string message3, string message4)
        {
            Assert.AreEqual(i, element1.Count, "The expected " + message1 + " does not exist on the page." +
                                                                            "\nActual result: " + element1.ToString());
            Assert.AreEqual(i, element2.Count, "The expected " + message2 + " does not exist on the page." +
                                                                            "\nActual result: " + element2.ToString());
            Assert.AreEqual(i, element3.Count, "The expected " + message3 + " does not exist on the page." +
                                                                            "\nActual result: " + element3.ToString());
            Assert.AreEqual(i, element4.Count, "The expected " + message4 + " does not exist on the page." +
                                                                           "\nActual result: " + element4.ToString());
        }


        public static void CheckStepsElements(int i, IList element1, IList element2, IList element3, IList element4,
                IList element5, string message1, string message2, string message3, string message4, string message5)
        {
            Assert.AreEqual(i, element1.Count, "The expected " + message1 + " does not exist on the page." +
                                                                            "\nActual result: " + element1.ToString());
            Assert.AreEqual(i, element2.Count, "The expected " + message2 + " does not exist on the page." +
                                                                            "\nActual result: " + element2.ToString());
            Assert.AreEqual(i, element3.Count, "The expected " + message3 + " does not exist on the page." +
                                                                            "\nActual result: " + element3.ToString());
            Assert.AreEqual(i, element4.Count, "The expected " + message4 + " does not exist on the page." +
                                                                           "\nActual result: " + element4.ToString());
            Assert.AreEqual(i, element5.Count, "The expected " + message5 + " does not exist on the page." +
                                                                           "\nActual result: " + element5.ToString());
        }

        public static void CheckStepsElements(int i, IList element1, IList element2, IList element3, IList element4,
                 IList element5, IList element6, string message1, string message2, string message3, string message4, 
                                                                                   string message5, string message6)
        {
            Assert.AreEqual(i, element1.Count, "The expected " + message1 + " does not exist on the page." +
                                                                            "\nActual result: " + element1.ToString());
            Assert.AreEqual(i, element2.Count, "The expected " + message2 + " does not exist on the page." +
                                                                            "\nActual result: " + element2.ToString());
            Assert.AreEqual(i, element3.Count, "The expected " + message3 + " does not exist on the page." +
                                                                            "\nActual result: " + element3.ToString());
            Assert.AreEqual(i, element4.Count, "The expected " + message4 + " does not exist on the page." +
                                                                           "\nActual result: " + element4.ToString());
            Assert.AreEqual(i, element5.Count, "The expected " + message5 + " does not exist on the page." +
                                                                           "\nActual result: " + element5.ToString());
            Assert.AreEqual(i, element6.Count, "The expected " + message6 + " does not exist on the page." +
                                                                           "\nActual result: " + element6.ToString());
        }

        public static void CheckStepsElements(int i, IList element1, IList element2, IList element3, IList element4,
        IList element5, IList element6, IList element7, string message1, string message2, string message3, string message4,
                                                                         string message5, string message6, string message7)
        {
            Assert.AreEqual(i, element1.Count, "The expected " + message1 + " does not exist on the page." +
                                                                            "\nActual result: " + element1.ToString());
            Assert.AreEqual(i, element2.Count, "The expected " + message2 + " does not exist on the page." +
                                                                            "\nActual result: " + element2.ToString());
            Assert.AreEqual(i, element3.Count, "The expected " + message3 + " does not exist on the page." +
                                                                            "\nActual result: " + element3.ToString());
            Assert.AreEqual(i, element4.Count, "The expected " + message4 + " does not exist on the page." +
                                                                           "\nActual result: " + element4.ToString());
            Assert.AreEqual(i, element5.Count, "The expected " + message5 + " does not exist on the page." +
                                                                           "\nActual result: " + element5.ToString());
            Assert.AreEqual(i, element6.Count, "The expected " + message6 + " does not exist on the page." +
                                                                           "\nActual result: " + element6.ToString());
            Assert.AreEqual(i, element7.Count, "The expected " + message7 + " does not exist on the page." +
                                                                           "\nActual result: " + element7.ToString());
        }

        #endregion



    }
}
