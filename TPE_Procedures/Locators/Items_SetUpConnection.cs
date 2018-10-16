namespace TPE_ProceduresUI.Tests
{
    public class Items_SetUpConnection
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
              
    }
}
