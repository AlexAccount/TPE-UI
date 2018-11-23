using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace TPE_ProceduresUI.Basic
{
    public class Visibility
    {
        public static void ElementIsVisible(IWebElement element, string elementName)
        {
            bool value = element.Displayed;
            Assert.IsTrue(value, elementName + " is not visible on the page.");
           
        }

        public static void ElementIsVisible(IWebElement element1, IWebElement element2, string elementName1, string elementName2)
        {
            bool value1 = element1.Displayed;
            bool value2 = element2.Displayed;
            Assert.IsTrue(value1, elementName1 + " is not visible on the page.");
            Assert.IsTrue(value2, elementName2 + " is not visible on the page.");
        }

        public static void ElementIsVisible(IWebElement element1, IWebElement element2, IWebElement element3,
                                            string elementName1, string elementName2, string elementName3)
        {
            bool value1 = element1.Displayed;
            bool value2 = element2.Displayed;
            bool value3 = element3.Displayed;
            Assert.IsTrue(value1, elementName1 + " is not visible on the page.");
            Assert.IsTrue(value2, elementName2 + " is not visible on the page.");
            Assert.IsTrue(value3, elementName3 + " is not visible on the page.");
        }

        public static void ElementIsVisible(IWebElement element1, IWebElement element2, IWebElement element3, IWebElement element4,
                                           string elementName1, string elementName2, string elementName3, string elementName4)
        {
            bool value1 = element1.Displayed;
            bool value2 = element2.Displayed;
            bool value3 = element3.Displayed;
            bool value4 = element4.Displayed;
            Assert.IsTrue(value1, elementName1 + " is not visible on the page.");
            Assert.IsTrue(value2, elementName2 + " is not visible on the page.");
            Assert.IsTrue(value3, elementName3 + " is not visible on the page.");
            Assert.IsTrue(value4, elementName4 + " is not visible on the page.");
        }

        public static void ElementIsVisible(IWebElement element1, IWebElement element2, IWebElement element3, IWebElement element4,
        IWebElement element5, string elementName1, string elementName2, string elementName3, string elementName4, string elementName5)
        {
            bool value1 = element1.Displayed;
            bool value2 = element2.Displayed;
            bool value3 = element3.Displayed;
            bool value4 = element4.Displayed;
            bool value5 = element5.Displayed;
            Assert.IsTrue(value1, elementName1 + " is not visible on the page.");
            Assert.IsTrue(value2, elementName2 + " is not visible on the page.");
            Assert.IsTrue(value3, elementName3 + " is not visible on the page.");
            Assert.IsTrue(value4, elementName4 + " is not visible on the page.");
            Assert.IsTrue(value5, elementName5 + " is not visible on the page.");
        }

        public static void ElementIsVisible(IWebElement element1, IWebElement element2, IWebElement element3, IWebElement element4,
        IWebElement element5, IWebElement element6, string elementName1, string elementName2, string elementName3, string elementName4,
        string elementName5, string elementName6)
        {
            bool value1 = element1.Displayed;
            bool value2 = element2.Displayed;
            bool value3 = element3.Displayed;
            bool value4 = element4.Displayed;
            bool value5 = element5.Displayed;
            bool value6 = element6.Displayed;
            Assert.IsTrue(value1, elementName1 + " is not visible on the page.");
            Assert.IsTrue(value2, elementName2 + " is not visible on the page.");
            Assert.IsTrue(value3, elementName3 + " is not visible on the page.");
            Assert.IsTrue(value4, elementName4 + " is not visible on the page.");
            Assert.IsTrue(value5, elementName5 + " is not visible on the page.");
            Assert.IsTrue(value6, elementName6 + " is not visible on the page.");
        }

        public static void ElementIsVisible(IWebElement element1, IWebElement element2, IWebElement element3, IWebElement element4,
       IWebElement element5, IWebElement element6, IWebElement element7, string elementName1, string elementName2, string elementName3,
       string elementName4, string elementName5, string elementName6, string elementName7)
        {
            bool value1 = element1.Displayed;
            bool value2 = element2.Displayed;
            bool value3 = element3.Displayed;
            bool value4 = element4.Displayed;
            bool value5 = element5.Displayed;
            bool value6 = element6.Displayed;
            bool value7 = element7.Displayed;
            Assert.IsTrue(value1, elementName1 + " is not visible on the page.");
            Assert.IsTrue(value2, elementName2 + " is not visible on the page.");
            Assert.IsTrue(value3, elementName3 + " is not visible on the page.");
            Assert.IsTrue(value4, elementName4 + " is not visible on the page.");
            Assert.IsTrue(value5, elementName5 + " is not visible on the page.");
            Assert.IsTrue(value6, elementName6 + " is not visible on the page.");
            Assert.IsTrue(value7, elementName7 + " is not visible on the page.");
        }
    }
}
