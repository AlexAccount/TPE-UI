using Microsoft.VisualStudio.TestTools.UITesting;
using System.Collections;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TPE_ProceduresUI.Tests
{
    public class UIOperability
    {
        public static void _uiOperability()
        {
            //Log off
            Basic.BasicMethods.LogOff_TPE();
            Playback.Wait(3000);
            //LogIn
            Basic.BasicMethods.LogIn_TPE();
            Playback.Wait(8000);

            //Check common Expand & Collapse buttons ("+" & "-") 
            IWebElement MinusBtn = Basic.DriverSingletone.Chrome_Driver.FindElement(By.XPath(Items_SetUpConnection.MinusBtn_L));
            IWebElement PlusBtn = Basic.DriverSingletone.Chrome_Driver.FindElement(By.XPath(Items_SetUpConnection.PlusBtn_L));

            PlusBtn.Click();
                IList DrumTransfer = Basic.DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_SetUpConnection.DrumTransfer_L));
                IList CarProtB = Basic.DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_SetUpConnection.CarProtB_L));
                IList GridVolt = Basic.DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_SetUpConnection.GridVolt_L));
                IList PowManag = Basic.DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_SetUpConnection.PowManag_L));
                IList LDAPowS = Basic.DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_SetUpConnection.LDAPowS_L));
                IList TestLDALow = Basic.DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_SetUpConnection.TestLDALow_L));

            Basic.BasicMethods.CheckElementExistance(2, DrumTransfer, "DrumTransfer tree NOT FOUND");
            Basic.BasicMethods.CheckElementExistance(1, CarProtB, "Carrier protection board tree NOT FOUND");
            Basic.BasicMethods.CheckElementExistance(1, GridVolt, "Test carrier protection grid voltage procedure NOT FOUND");
            Basic.BasicMethods.CheckElementExistance(2, PowManag, "Power Management tree NOT FOUND");
            Basic.BasicMethods.CheckElementExistance(1, LDAPowS, "Lda Power Supply 12V tree NOT FOUND");
            Basic.BasicMethods.CheckElementExistance(1, TestLDALow, "Test LDA low voltage power supply procedure NOT FOUND");

            MinusBtn.Click();
                Basic.BasicMethods.CheckElementExistance(0, DrumTransfer, "There is DrumTransfer on the page");
                Basic.BasicMethods.CheckElementExistance(0, CarProtB, "There is Carrier protection board tree on the page");
                Basic.BasicMethods.CheckElementExistance(0, GridVolt, "There is Test carrier protection grid voltage procedure on the page");
                Basic.BasicMethods.CheckElementExistance(0, PowManag, "There is Power Management tree on the page");
                Basic.BasicMethods.CheckElementExistance(0, LDAPowS, "There is Lda Power Supply 12V tree on the page");
                Basic.BasicMethods.CheckElementExistance(0, TestLDALow, "There is Test LDA low voltage power supply procedure on the page");

            ////Check Full Screen (only Android)
            //IWebElement FullScreenBtn = Basic.DriverSingletone.Chrome_Driver.FindElement(By.Id(Locators.FullScreenBtn));
            //FullScreenBtn.Click();
            //Playback.Wait(1000);

            //Switch from Tree view to Folder view
            IWebElement FolderViewBtn = Basic.DriverSingletone.Chrome_Driver.FindElement(By.XPath(Items_SetUpConnection.FolderViewBtn_L));
            FolderViewBtn.Click();
            IList MinusBtn_NO = Basic.DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_SetUpConnection.MinusBtn_L));
            IList PlusBtnNO = Basic.DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_SetUpConnection.PlusBtn_L));
                 Basic.BasicMethods.CheckElementExistance(0 , MinusBtn_NO, "The UI didn't switch to Folder View");
                 Basic.BasicMethods.CheckElementExistance(0, PlusBtnNO, "The UI didn't switch to Folder View");

            //Select any folder and test Up & Home button 
            IWebElement AnyFolder = Basic.DriverSingletone.Chrome_Driver.FindElement(By.XPath(Items_SetUpConnection.AnyFolder_L)); //now it's New Active Procedures. Later it should be changed on Real
            AnyFolder.Click();
                Basic.BasicMethods.CheckElementExistance(1, DrumTransfer, "Nested folder hasn't been opened");

            //Verify that Up button allows user to go one level up in the list
            IWebElement ParantLevBtn = Basic.DriverSingletone.Chrome_Driver.FindElement(By.XPath(Items_SetUpConnection.ParantLevBtn_L));
                Assert.IsTrue(ParantLevBtn.Enabled, "Parent Level button is disabled");

            //Verify that Home button returns initial list of procedures groups
            IWebElement HomeBtn = Basic.DriverSingletone.Chrome_Driver.FindElement(By.XPath(Items_SetUpConnection.HomeBtn_L));
                HomeBtn.Click();
                    Assert.IsTrue(!HomeBtn.Enabled, "Open root level button is enabled");
                    
            //Switch from Folder view to Tree view again and Check operability of Expand & Collapse buttons
            FolderViewBtn.Click();
                PlusBtn.Click();
                    Basic.BasicMethods.CheckElementExistance(2, DrumTransfer, "DrumTransfer tree NOT FOUND");
                    Basic.BasicMethods.CheckElementExistance(1, CarProtB, "Carrier protection board tree NOT FOUND");
                    Basic.BasicMethods.CheckElementExistance(1, GridVolt, "Test carrier protection grid voltage procedure NOT FOUND");
                    Basic.BasicMethods.CheckElementExistance(2, PowManag, "Power Management tree NOT FOUND");
                    Basic.BasicMethods.CheckElementExistance(1, LDAPowS, "Lda Power Supply 12V tree NOT FOUND");
                    Basic.BasicMethods.CheckElementExistance(1, TestLDALow, "Test LDA low voltage power supply procedure NOT FOUND");
                MinusBtn.Click();
                    Basic.BasicMethods.CheckElementExistance(0, DrumTransfer, "There is DrumTransfer on the page");
                    Basic.BasicMethods.CheckElementExistance(0, CarProtB, "There is Carrier protection board tree on the page");
                    Basic.BasicMethods.CheckElementExistance(0, GridVolt, "There is Test carrier protection grid voltage procedure on the page");
                    Basic.BasicMethods.CheckElementExistance(0, PowManag, "There is Power Management tree on the page");
                    Basic.BasicMethods.CheckElementExistance(0, LDAPowS, "There is Lda Power Supply 12V tree on the page");
                    Basic.BasicMethods.CheckElementExistance(0, TestLDALow, "There is Test LDA low voltage power supply procedure on the page");
        }   
    }
}
