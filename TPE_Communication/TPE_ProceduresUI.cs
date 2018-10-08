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
using TPE_ProceduresUI.Tests;

namespace TPE_ProceduresUI
{
    
    [CodedUITest]
    public class TPE_ProceduresUI
    {
        #region Output deployment path
        const string DEPLOYMENT_PATH = "Data\\Parameters.xml";
        #endregion

        [TestMethod]
        [DeploymentItem(DEPLOYMENT_PATH)]
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\Parameters\\Parameters.xml", "Config", DataAccessMethod.Sequential)]
        public void TC_1_SetUpConnection()
        {
            Basic.BasicMethods.GoTo_TPE();
            Playback.Wait(2000);
            SetUpConnection._SetUpConnection();
        }

        [TestMethod]
        public void TC_2_TestCarrierProtectionMainChargeVoltage_DoorsClosed()
        {
            TestCarrierProtMainChVolt._TestCarrierProtMainChVolt(); 
        }

        [TestMethod]
        public void TC_3_()
        {
            
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        //Use TestInitialize to run code before running each test 
        [TestInitialize()]
        public void MyTestInitialize()
        {
            
        }

        //Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup()
        {
           
        }

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
