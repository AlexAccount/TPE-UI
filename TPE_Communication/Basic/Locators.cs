namespace TPE_ProceduresUI.Tests
{
    public class Locators
    {
        //SetUp Connection Group
        public static string WelcomeMessage_L = "//label[contains (text(), 'Enter PIN code you see in MyPress')]";
        public static string MainPage_L = "//h1[contains (text(), 'Procedures')]";
        public static string ServerOFF_L = "//p[contains (text(), 'Tablet server was shut down.')]";
        public static string ReconnectBtn_L = "//button[contains (text(), 'Reconnect')]";

        //UIOperability Group
        public static string MinusBtn_L = "//button[@title = 'Collapse All']";
        public static string PlusBtn_L = "//button[@title = 'Expand All']";
        public static string DrumTransfer_L = "//span[contains (text(), 'Drum transfer')]";
        public static string CarProtB_L = "//span[contains (text(), 'Carrier protection board')]";
        public static string GridVolt_L = "//span[contains (text(), 'Test carrier protection grid voltage')]";
        public static string PowManag_L = "//span[contains (text(), 'Power Management')]";
        public static string LDAPowS_L = "//span[contains (text(), 'Lda Power Supply 12V')]";
        public static string TestLDALow_L = "//span[contains (text(), 'Test LDA low voltage power supply')]";
        public static string FullScreenBtn = "full-screen";
        public static string FolderViewBtn_L = "//button[@title = 'Tree/Tiles View']";
        public static string AnyFolder_L = "//span[contains(text() , 'New Active Procedures')]";
        public static string ParantLevBtn_L = "//button[@title = 'Open Parent Level']";
        public static string HomeBtn_L = "//button[@title = 'Open Root Level']";

        //TC_2_TestCarrierProtectionMainChargeVoltage_DoorsClosed Group
        public static string DrumTransfer = "//span[contains (text(), 'Drum transfer')]";
        public static string CarrierBoard = "//span[contains (text(), 'Carrier protection board')]";
        public static string TestCPMCV = "//span[contains (text(), 'Test carrier protection main charge voltage')]";
        public static string Header1 = "//h1[contains(text(), 'Test carrier protection main charge voltage')]";
        public static string Header2 = "//h3[contains(text(), 'Procedure Test carrier protection main charge voltage')]";
        public static string SelectSTOpt = "//div[contains(text(), 'Select a start option')]";
        public static string DoorsClosed = "step-nav-0";
        public static string PreparationHeader = "//h3[contains(text(), '1. Preparation')]";
        public static string B_RemoveDrums = "//li[contains(text(), 'Remove drums')]";
        public static string B_CloseDoors = "//li[contains(text(), 'Close doors: Input, Left and Right. Dock PMC')]";
        public static string B_RemoveClear = "//li[contains(text(), 'Remove clear safety covers')]";
        public static string B_AllDipswitches = "//li[contains(text(), 'All dipswitches on carrier protection board must be switched on except switch 3.4')]";
        public static string B_ExecuteBtn = "execute-btn";
        public static string Step3 = "//h3[contains (text(), '3. Select units')]";
        public static string WaitMess = "//span[contains(text(), 'Waiting on input')]";
        public static string iIcon = "fa fa-info-circle";
        public static string X4Title = "//div[contains(text(), 'X4')]";
        public static string X3Title = "//div[contains(text(), 'X3')]";
        public static string X2Title = "//div[contains(text(), 'X2')]";
        public static string X1Title = "//div[contains(text(), 'X1')]";
        public static string X0Title = "//div[contains(text(), 'X0')]";
        public static string SelPU = "//div[contains(text(), 'Select print units')]";
        public static string X4_B = "//label[contains(text(), 'X4')]";
        public static string X3_B = "//label[contains(text(), 'X3')]";
        public static string X2_B = "//label[contains(text(), 'X2')]";
        public static string X1_B = "//label[contains(text(), 'X1')]";
        public static string X0_B = "//label[contains(text(), 'X0')]";
        public static string X4_ChB = "CheckBox_0";
        public static string X3_ChB = "CheckBox_1";
        public static string X2_ChB = "CheckBox_2";
        public static string X1_ChB = "CheckBox_3";
        public static string X0_ChB = "CheckBox_4";
        public static string AllBtnB = "//button[contains(text(), 'All')]";
        public static string NoneBtnB = "//button[contains(text(), 'None')]";
        public static string SandclockIcon = "busy";
        public static string ValidMessage = "//span[contains(text(), 'Validating')]";
        public static string DescriptionMessage_4 = "//div[contains(text(), 'This procedure will automatically test the carrier protection detection of the high voltage supplies which are selected at the top of the procedure pane. This may take several minutes. The main charge high voltage supply will be disabled. The Carrier protection board normally detects an alarm within 15 seconds; if not, the test failed and a red cross is displayed at the top of the procedure pane. If selected, the next high voltage supply will be tested automatically.')]";
        public static string OK_Mess = "//span[contains(text(), 'Ok')]";
        public static string Step_5 = "//h3[contains(text(), '5. Stop procedure')]";
        public static string RemoutDrumsItem = "//li[contains(text(), 'Remount drums')]";
        public static string RemoutClearCovItem = "//li[contains(text(), 'Remount clear safety covers')]";
        public static string InitStateMess = "//span[contains(text(), 'The engine is ready at Initialized')]";
        public static string ProcedureSuccess = "//span[contains(text(), 'The procedure has been successfully finished')]";
    }
}
