namespace TPE_ProceduresUI
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using Tests;

    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public partial class UIMap
    {
        #region Instances
        public static SetUpConnection setUpConnection = new SetUpConnection();
        #endregion




        #region Properties
        public UIX800Diana600401447XeWindow UIX800Diana600401447XeWindow
        {
            get
            {
                if ((this.mUIX800Diana600401447XeWindow == null))
                {
                    this.mUIX800Diana600401447XeWindow = new UIX800Diana600401447XeWindow();
                }
                return this.mUIX800Diana600401447XeWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIX800Diana600401447XeWindow mUIX800Diana600401447XeWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIX800Diana600401447XeWindow : WinWindow
    {
        
        public UIX800Diana600401447XeWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "X-800 Diana 6.00.40.1447 - Xeikon CX500 (S/N 998004117) - SIMULATION - DEMO - DL-" +
                "306A-12\\Alex - technician (Technicians)";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("X-800 Diana 6.00.40.1447 - Xeikon CX500 (S/N 998004117) - SIMULATION - DEMO - DL-" +
                    "306A-12\\Alex - technician (Technicians)");
            #endregion
        }
        
        #region Properties
        public UITabletwebserveronWindow UITabletwebserveronWindow
        {
            get
            {
                if ((this.mUITabletwebserveronWindow == null))
                {
                    this.mUITabletwebserveronWindow = new UITabletwebserveronWindow(this);
                }
                return this.mUITabletwebserveronWindow;
            }
        }
        
        public UIM_listBoxWindow UIM_listBoxWindow
        {
            get
            {
                if ((this.mUIM_listBoxWindow == null))
                {
                    this.mUIM_listBoxWindow = new UIM_listBoxWindow(this);
                }
                return this.mUIM_listBoxWindow;
            }
        }
        #endregion
        
        #region Fields
        private UITabletwebserveronWindow mUITabletwebserveronWindow;
        
        private UIM_listBoxWindow mUIM_listBoxWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UITabletwebserveronWindow : WinWindow
    {
        
        public UITabletwebserveronWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "m_webSeverToggle";
            this.WindowTitles.Add("X-800 Diana 6.00.40.1447 - Xeikon CX500 (S/N 998004117) - SIMULATION - DEMO - DL-" +
                    "306A-12\\Alex - technician (Technicians)");
            #endregion
        }
        
        #region Properties
        public WinCheckBox UITabletwebserveronCheckBox
        {
            get
            {
                if ((this.mUITabletwebserveronCheckBox == null))
                {
                    this.mUITabletwebserveronCheckBox = new WinCheckBox(this);
                    #region Search Criteria
                    this.mUITabletwebserveronCheckBox.SearchProperties[WinCheckBox.PropertyNames.Name] = "Tablet web server (on)";
                    this.mUITabletwebserveronCheckBox.WindowTitles.Add("X-800 Diana 6.00.40.1447 - Xeikon CX500 (S/N 998004117) - SIMULATION - DEMO - DL-" +
                            "306A-12\\Alex - technician (Technicians)");
                    #endregion
                }
                return this.mUITabletwebserveronCheckBox;
            }
        }
        
        public WinCheckBox UITabletwebserveroffCheckBox
        {
            get
            {
                if ((this.mUITabletwebserveroffCheckBox == null))
                {
                    this.mUITabletwebserveroffCheckBox = new WinCheckBox(this);
                    #region Search Criteria
                    this.mUITabletwebserveroffCheckBox.SearchProperties[WinCheckBox.PropertyNames.Name] = "Tablet web server (off)";
                    this.mUITabletwebserveroffCheckBox.WindowTitles.Add("X-800 Diana 6.00.40.1447 - Xeikon CX500 (S/N 998004117) - SIMULATION - DEMO - DL-" +
                            "306A-12\\Alex - technician (Technicians)");
                    #endregion
                }
                return this.mUITabletwebserveroffCheckBox;
            }
        }
        #endregion
        
        #region Fields
        private WinCheckBox mUITabletwebserveronCheckBox;
        
        private WinCheckBox mUITabletwebserveroffCheckBox;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIM_listBoxWindow : WinWindow
    {
        
        public UIM_listBoxWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "m_listBox";
            this.WindowTitles.Add("X-800 Diana 6.00.40.1447 - Xeikon CX500 (S/N 998004117) - SIMULATION - DEMO - DL-" +
                    "306A-12\\Alex - technician (Technicians)");
            #endregion
        }
        
        #region Properties
        public WinListItem UIItem02042018152638TaListItem
        {
            get
            {
                if ((this.mUIItem02042018152638TaListItem == null))
                {
                    this.mUIItem02042018152638TaListItem = new WinListItem(this);
                    #region Search Criteria
                    this.mUIItem02042018152638TaListItem.SearchProperties[WinListItem.PropertyNames.Name] = "02/04/2018 15:26:38 Tablet device connected:";
                    this.mUIItem02042018152638TaListItem.WindowTitles.Add("X-800 Diana 6.00.40.1447 - Xeikon CX500 (S/N 998004117) - SIMULATION - DEMO - DL-" +
                            "306A-12\\Alex - technician (Technicians)");
                    #endregion
                }
                return this.mUIItem02042018152638TaListItem;
            }
        }
        #endregion
        
        #region Fields
        private WinListItem mUIItem02042018152638TaListItem;
        #endregion
    }
}
