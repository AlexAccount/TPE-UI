using Microsoft.VisualStudio.TestTools.UITesting;
using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPE_ProceduresUI.Basic;

namespace TPE_ProceduresUI.Tests
{
    public class TestCarrierProtMainChVolt
    {
        public static void _TestCarrierProtMainChVolt()
        {
            #region Variables 
            
            #endregion

            //Go to Drum transfer
            IWebElement DrumTransfer_E = DriverSingletone.Chrome_Driver.FindElement(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.DrumTransfer));
                DrumTransfer_E.Click();
                    Playback.Wait(2000);

            //Verify new tree Carrier protection board exists
            IList CarrierProtBoard = DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.CarrierBoard));
            IWebElement CarrierProtBoard_E = DriverSingletone.Chrome_Driver.FindElement(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.CarrierBoard));
                ElementExists.CheckStepsElements(1, CarrierProtBoard, 
                    "Carrier protection board tree");
                            
            //Go to Carrier protection board
            CarrierProtBoard_E.Click();
                    

            //Verify TestCarrierProtectionMainChargeVoltage procedure exists in the list
            IList TestCPMCV = DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.TestCPMCV));
                ElementExists.CheckStepsElements(1, TestCPMCV, 
                    "Test carrier protection main charge voltage procedure");

            //Click on the procedure
            IWebElement TestCPMCV_E = DriverSingletone.Chrome_Driver.FindElement(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.TestCPMCV));
                TestCPMCV_E.Click();
                    Playback.Wait(1500);

            /* 
            Verify there are no overlapping of content after going to Test carrier protection main charge voltage page
            Verify the headers exist: 
            - Test carrier protection main charge voltage
            - Procedure Test carrier protection main charge voltage
            - Verify the message "Select a start option" exists 
            - Verify that button "Doors closed" exists
            */
            
            IList Header1_L = DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.Header1));
            IList Header2_L = DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.Header2));
            IList SlectSTOpt_L = DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.SelectSTOpt));
            IList DoorsClosed_L = DriverSingletone.Chrome_Driver.FindElements(By.Id(Items_TestCarrierProtectionMainChargeVoltage_Closed.DoorsClosed));
            IWebElement Header1_E = DriverSingletone.Chrome_Driver.FindElement(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.Header1));
            IWebElement Header2_E = DriverSingletone.Chrome_Driver.FindElement(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.Header2));
            IWebElement SlectSTOpt_E = DriverSingletone.Chrome_Driver.FindElement(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.SelectSTOpt));
            IWebElement DoorsClosed_E = DriverSingletone.Chrome_Driver.FindElement(By.Id(Items_TestCarrierProtectionMainChargeVoltage_Closed.DoorsClosed));

            Visibility.ElementIsVisible(Header1_E, Header2_E, SlectSTOpt_E, DoorsClosed_E, 
                "\"Test carrier protection main charge voltage\" main header",
                "\"Procedure Test carrier protection main charge voltage\" second header",
                "\"Select a start option\" message", 
                "\"Doors closed\" buuton");
            ElementExists.CheckStepsElements(1, Header1_L, Header2_L, SlectSTOpt_L, DoorsClosed_L, 
                "Test carrier protection main charge voltage header", 
                "Procedure Test carrier protection main charge voltage header", 
                "Select a start option message", 
                "Doors closed button");

            //Click on the Doors closed button 
            IWebElement DoorsClosed = DriverSingletone.Chrome_Driver.FindElement(By.Id(Items_TestCarrierProtectionMainChargeVoltage_Closed.DoorsClosed));
                DoorsClosed.Click();
                    Playback.Wait(1500);

            //Verify Step 1 Preaparation is appeared
            IList PrearationHeader_E = DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.PreparationHeader));
                ElementExists.CheckStepsElements(1, PrearationHeader_E, 
                    "Preparation step Header");

            /*
            There are Boolets:
            - Remove drums
            - Close doors: Input, Left and Right. Dock PMC
            - Remove clear safety covers
            - All dipswitches on carrier protection board must be 
            Verify there are no overlapping of content after going to Preparation step
            */
            IList B_RemoveDrums_L = DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.B_RemoveDrums));
            IList B_ClooseDoors_L = DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.B_CloseDoors));
            IList B_RemoveClear_L = DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.B_RemoveClear));
            IList B_AllDipswitches_L = DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.B_AllDipswitches));
            IWebElement B_RemoveDrums_E = DriverSingletone.Chrome_Driver.FindElement(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.B_RemoveDrums));
            IWebElement B_ClooseDoors_E = DriverSingletone.Chrome_Driver.FindElement(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.B_CloseDoors));
            IWebElement B_RemoveClear_E = DriverSingletone.Chrome_Driver.FindElement(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.B_RemoveClear));
            IWebElement B_AllDipswitches_E = DriverSingletone.Chrome_Driver.FindElement(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.B_AllDipswitches));

            ElementExists.CheckStepsElements(1, B_RemoveDrums_L, B_ClooseDoors_L, B_RemoveClear_L, B_AllDipswitches_L,
                "Remove drums boolet",
                "Close doors: Input, Left and Right. Dock PMC boolet",
                "Remove clear safety covers boolet",
                "All dipswitches on carrier protection board must be switched on except switch 3.4 boolet");
            Visibility.ElementIsVisible(B_RemoveDrums_E, B_ClooseDoors_E, B_RemoveClear_E, B_AllDipswitches_E,
                "\"Remove drums\" boolet",
                "\"Close doors: Input, Left and Right. Dock PMC\" boolet",
                "\"Remove clear safety covers\" boolet",
                "\"All dipswitches on carrier protection board must be switched on except switch 3.4\" boolet");

            //Click the Execute button
            IWebElement ExecuteBtn_E = DriverSingletone.Chrome_Driver.FindElement(By.Id(Items_TestCarrierProtectionMainChargeVoltage_Closed.B_ExecuteBtn));

            ExecuteBtn_E.Click();

            //Text "3. Select units" exists
            IList Step3_L = DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.Step3));

            ElementExists.CheckStepsElements(1, Step3_L, "Step 3 header \"Slect units\"");

            //There is a message "Waiting on input" in the bottom
            IList WaitMess_L = DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.WaitMess));
            IList iIcon_L = DriverSingletone.Chrome_Driver.FindElements(By.ClassName(Items_TestCarrierProtectionMainChargeVoltage_Closed.iIcon));

            ElementExists.CheckStepsElements(1, WaitMess_L, iIcon_L,
                "\"Waiting on input\" message",
                "\"Info icon\"");

            //There are titiles: X4, X3, X2, X1
            IList X4_L = DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.X4Title));
            IList X3_L = DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.X3Title));
            IList X2_L = DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.X2Title));
            IList X1_L = DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.X1Title));
            IList X0_L = DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.X0Title));

            ElementExists.CheckStepsElements(1, X4_L, X3_L, X2_L, X1_L, X0_L,
                "\"X4 title\"",
                "\"X3 title\"",
                "\"X2 title\"",
                "\"X1 title\"",
                "\"X0 title\"");

            //There is step description "Select print units"
            IList SelPU_L = DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.SelPU));

            //There are checkboxes: X4, X3, X2, X1
            IList X4B_L = DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.X4_B));
            IList X3B_L = DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.X3_B));
            IList X2B_L = DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.X2_B));
            IList X1B_L = DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.X1_B));
            IList X0B_L = DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.X0_B));
            IList X4ChB_L = DriverSingletone.Chrome_Driver.FindElements(By.Id(Items_TestCarrierProtectionMainChargeVoltage_Closed.X4_ChB));
            IList X3ChB_L = DriverSingletone.Chrome_Driver.FindElements(By.Id(Items_TestCarrierProtectionMainChargeVoltage_Closed.X3_ChB));
            IList X2ChB_L = DriverSingletone.Chrome_Driver.FindElements(By.Id(Items_TestCarrierProtectionMainChargeVoltage_Closed.X2_ChB));
            IList X1ChB_L = DriverSingletone.Chrome_Driver.FindElements(By.Id(Items_TestCarrierProtectionMainChargeVoltage_Closed.X1_ChB));
            IList X0ChB_L = DriverSingletone.Chrome_Driver.FindElements(By.Id(Items_TestCarrierProtectionMainChargeVoltage_Closed.X0_ChB));

            ElementExists.CheckStepsElements(1, X4B_L, X3B_L, X2B_L, X1B_L, X0B_L,
                "X4 checkbox title",
                "X3 checkbox title",
                "X2 checkbox title",
                "X1 checkbox title",
                "X0 checkbox title");
            ElementExists.CheckStepsElements(1, X4ChB_L, X3ChB_L, X2ChB_L, X1ChB_L, X0ChB_L,
               "X4 checkbox",
               "X3 checkbox",
               "X2 checkbox",
               "X1 checkbox",
               "X0 checkbox");

            //There is button "All'
            IList AllButton_L = DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.AllBtnB));
                ElementExists.CheckStepsElements(1, AllButton_L, "All button");

            //There is button "None"
            IList NoneBtn_L = DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.NoneBtnB));
                ElementExists.CheckStepsElements(1, NoneBtn_L, "None button");

            //Verify there are no overlapping of content after going to Select units step
            IWebElement AllButton_E = DriverSingletone.Chrome_Driver.FindElement(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.AllBtnB));
            IWebElement NoneBtn_E = DriverSingletone.Chrome_Driver.FindElement(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.NoneBtnB));
                Visibility.ElementIsVisible(AllButton_E, NoneBtn_E, "The All button", "The None button");

            //Click on the All button
            AllButton_E.Click();

            //Click the Execute button
            ExecuteBtn_E.Click();
                Playback.Wait(6000);

            //There is a message "Validating" in the bottom
            IList VallidMess_L = DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.ValidMessage));
            IWebElement VallidMess_E = DriverSingletone.Chrome_Driver.FindElement(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.ValidMessage));
                ElementExists.CheckStepsElements(1, VallidMess_L, "The Validating message in the bottom");
                Visibility.ElementIsVisible(VallidMess_E, "The Validating message in the bottom");

            //Busy sand clocks are displayed on X1, X2, X3, X4
            IList SandClockItem_L = DriverSingletone.Chrome_Driver.FindElements(By.ClassName(Items_TestCarrierProtectionMainChargeVoltage_Closed.SandclockIcon));
            IWebElement SandClockItem_E = DriverSingletone.Chrome_Driver.FindElement(By.ClassName(Items_TestCarrierProtectionMainChargeVoltage_Closed.SandclockIcon));
            ElementExists.CheckStepsElements(1, SandClockItem_L, "The X0 sandclocks");
            Visibility.ElementIsVisible(SandClockItem_E, "The sandclock icon for X0");
                    Playback.Wait(40000);
                ElementExists.CheckStepsElements(1, SandClockItem_L, "The X1 sandclocks");
                Visibility.ElementIsVisible(SandClockItem_E, "The sandclock icon for X1");
                    Playback.Wait(40000);
                ElementExists.CheckStepsElements(1, SandClockItem_L, "The X2 sandclocks");
                Visibility.ElementIsVisible(SandClockItem_E, "The sandclock icon for X2");
                    Playback.Wait(40000);
                ElementExists.CheckStepsElements(1, SandClockItem_L, "The X3 sandclocks");
                Visibility.ElementIsVisible(SandClockItem_E, "The sandclock icon for X3");
                    Playback.Wait(40000);
                ElementExists.CheckStepsElements(1, SandClockItem_L, "The X4 sandclocks");
                Visibility.ElementIsVisible(SandClockItem_E, "The sandclock icon for X4");
                    Playback.Wait(40000);
            
            /*
            There is description "This procedure will automatically test the carrier protection detection of the high voltage supplies which are selected at the top of the procedure pane. This may take several minutes.
            The main charge high voltage supply will be disabled.
            The Carrier protection board normally detects an alarm within 15 seconds; if not, the test failed and a red cross is displayed at the top of the procedure pane.
            If selected, the next high voltage supply will be tested automatically." 
            */
            IList DescriptionMessage_4_L = DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.DescriptionMessage_4));
            IWebElement DescriptionMessage_4_E = DriverSingletone.Chrome_Driver.FindElement(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.DescriptionMessage_4));
                ElementExists.CheckStepsElements(1, DescriptionMessage_4_L, "The 4th description step");
                Visibility.ElementIsVisible(DescriptionMessage_4_E, "The 4th description step");

            //When all supplies have been validated There is a message "Ok" in the bottom
            IList OkMessage_L = DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.OK_Mess));
            IWebElement OkMessage_E = DriverSingletone.Chrome_Driver.FindElement(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.OK_Mess));
                ElementExists.CheckStepsElements(1, OkMessage_L, "The Ok success message");
                Visibility.ElementIsVisible(OkMessage_E, "The Ok success message");

            //Click Execute 
            ExecuteBtn_E.Click();
                Playback.Wait(6000);

            //"5. Stop procedure" step opens
            //There are boolets with text: - Remount drums; - Remount clear safety covers
            //There is a message "The engine is ready at Initialized" message in the bottom ?????
            //Verify there are no overlapping of content after going to Stop procedure step
            IList StopStep_L = DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.Step_5));
            IList RemDrBoolet_L = DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.RemoutDrumsItem));
            IList RemClBoolet_L = DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.RemoutClearCovItem));
            IList InitInfoMess_L = DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.InitStateMess));
            IWebElement StopStep_E = DriverSingletone.Chrome_Driver.FindElement(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.Step_5));
            IWebElement RemDrBoolet_E = DriverSingletone.Chrome_Driver.FindElement(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.RemoutDrumsItem));
            IWebElement RemClBoolet_E = DriverSingletone.Chrome_Driver.FindElement(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.RemoutClearCovItem));
            IWebElement InitInfoMess_E = DriverSingletone.Chrome_Driver.FindElement(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.InitStateMess));
                ElementExists.CheckStepsElements(1, StopStep_L, RemDrBoolet_L, RemClBoolet_L, InitInfoMess_L, "The Stop procedure step",
                "The Remount drums step", "The remount clear safely covers", "The Initialized info message");
                Visibility.ElementIsVisible(StopStep_E, RemDrBoolet_E, RemClBoolet_E, InitInfoMess_E, "The Stop procedure step",
                "The Remount drums step", "The remount clear safely covers", "The Initialized info message");

            //Click Execute
            ExecuteBtn_E.Click();
                Playback.Wait(6000);

            //There is a message "The procedure has been successfully finished" 
            IList SuccessProcedure = DriverSingletone.Chrome_Driver.FindElements(By.XPath(Items_TestCarrierProtectionMainChargeVoltage_Closed.ProcedureSuccess));
                ElementExists.CheckStepsElements(1, SuccessProcedure, "The message about success of the procedure");

            //You are on the main page 
            Visibility.ElementIsVisible(DrumTransfer_E, "The Drum transfer tree");
        }

    }
}
