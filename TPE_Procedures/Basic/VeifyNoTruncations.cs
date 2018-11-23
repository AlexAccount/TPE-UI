using System.Drawing;
using System.Drawing.Imaging;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ColorDifference = Microsoft.Test.VisualVerification.ColorDifference;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.Test.VisualVerification;
using OpenQA.Selenium;
//using OpenQA.Selenium.OutputType;
//using static System.Net.WebRequestMethods;
using System.IO;
using System;
using SikuliSharp;
using Sikuli4Net.sikuli_REST;

namespace TPE_ProceduresUI.Basic
{
    public class VeifyNoTruncations
    {
        
        public static Image TakeCaptureOfElement(IWebElement element, string Name) 
        {
            Screenshot PageScreenShot = ((ITakesScreenshot)DriverSingletone.Chrome_Driver).GetScreenshot();
            PageScreenShot.SaveAsFile("capteredImg", ScreenshotImageFormat.Jpeg);

            Image img = Bitmap.FromFile(Name);
            Rectangle rect = new Rectangle();

            if (element != null)
            {
                int ElementWidth = element.Size.Width;
                int ElementHeight = element.Size.Height;

                System.Drawing.Point p = element.Location;

                rect = new Rectangle(p.X, p.Y, ElementWidth, ElementHeight);
            }

            Bitmap bmpImage = new Bitmap(img);
            var croppedImg = bmpImage.Clone(rect, bmpImage.PixelFormat);

            return croppedImg;
            
            #region test code
            //string FileName = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".jpg";
            //Byte[] byteArray = ((ITakesScreenshot)DriverSingletone.Chrome_Driver).GetScreenshot().AsByteArray;
            //Bitmap screenShot = new Bitmap(new MemoryStream(byteArray));
            //Rectangle croppedImg = new Rectangle
            //                                   (element.Location.X,
            //                                    element.Location.Y,
            //                                    element.Size.Width,
            //                                    element.Size.Height);
            //screenShot = screenShot.Clone(croppedImg, screenShot.PixelFormat);
            //screenShot.Save(String.Format(FileName, ScreenshotImageFormat.Jpeg));

            //var verifier = new SnapshotColorVerifier(Color.Black, new ColorDifference(255, 20, 20, 20));
            //Assert.AreEqual(screenShot.Equals(expected));

            #endregion
        }

        public static void VerifyTruncations(string ImgName)
        {
            Screen screen = new Screen();
                Pattern expectedImage = new Pattern(@ImgName, 0.9);
                    screen.Find(expectedImage);
        } 

        //public static void VerifyWindow(WinWindow window, Bitmap expectedBM, string message)
        //{            
        //        var expected = Snapshot.FromBitmap(expectedBM);
        //        var actual = Snapshot.FromRectangle(window.BoundingRectangle);
        //        var verifier = new SnapshotColorVerifier(Color.Black, new ColorDifference(255, 20, 20, 20));
        //        Assert.AreNotEqual(0, actual.Find(expected, verifier).Count, message);
         
        //}

    }
}


