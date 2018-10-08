using Microsoft.VisualStudio.TestTools.UITesting;
using System.Collections;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace TPE_ProceduresUI.Tests
{
    public class SetUpConnection : UIMap
    {
       public static void _SetUpConnection()
        {
            //Go to TPE page
            IList WelcomeMessage;
            WelcomeMessage = Basic.DriverSingletone.Chrome_Driver.FindElements(By.XPath(Locators.WelcomeMessage_L));
           
            //Verify you are on the page
            Basic.BasicMethods.CheckElementExistance(1, WelcomeMessage, "There is no Welcome message on the page");

            //Type in the password and click login
            Basic.BasicMethods.LogIn_TPE();
            Playback.Wait(10000);

            //Verify if you are logged in
            IList MainPage;
            MainPage = Basic.DriverSingletone.Chrome_Driver.FindElements(By.XPath(Locators.MainPage_L));
                Basic.BasicMethods.CheckElementExistance(1, MainPage, "Log In attempt failed");
                    Playback.Wait(5000);

            
        }
    }
}
