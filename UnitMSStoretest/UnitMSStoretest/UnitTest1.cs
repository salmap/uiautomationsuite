using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace UnitMSStoretest
{
    [TestClass]
    [DeploymentItem(@"C:\Users\salma\Documents\Dev\chromedriver_win32\chromedriver.exe")]
    public class UnitTest1
    {
        private static RemoteWebDriver driver;
        static OpenQA.Selenium.ICapabilities caps;
        static TestContext varctx;

        [ClassInitialize]
        public static void ClassInit(TestContext ctx)
        {
            caps = new ChromeOptions().ToCapabilities();
            varctx = ctx;

            DesiredCapabilities dc = new DesiredCapabilities("chrome", string.Empty, new Platform(PlatformType.Any));
            // new DesiredCapabilities("internet explorer", "11", Platform.CurrentPlatform);
            //below line for IE
            //driver = new RemoteWebDriver(new Uri("http://127.0.0.1:5555"), caps);
            //below line for Edge
            
            //driver.Manage().Window.Maximize();
            //just to show some change going through a branch.
            //here i go i did add some more to it now check it out 
 secondbranch
            //Let us see if this is what it is
            //this is the second branch i have done to see how it works
 master
        }

        [TestInitialize]
        public void TestInit()
        {
            driver = new RemoteWebDriver(new Uri("http://localhost:9515/"), caps);
        }

        [TestCleanup]
        public void cleanup()
        {
           // ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            //Screenshot screenshot = screenshotDriver.GetScreenshot();
            //screenshot.SaveAsFile("c:/temp/" + varctx.TestName + ".png", ScreenshotImageFormat.Png);
            driver.Close();
        }

        [TestMethod]
        public void TestMethod1()
        {

            driver.Navigate().GoToUrl("http://www.microsoftstore.com");
           
            //  driver.Manage().Window.Maximize();
            // driver.Manage().Window.Size = new System.Drawing.Size(1024, 768);


            //IWebElement cart = driver.FindElement(By.XPath("//*[@id='uhf - shopping - cart']"));
            IWebElement wingo = driver.FindElement(By.XPath("//*[@id='shellmenu_1']"));
            wingo.Click();

            IWebElement hmwndws = driver.FindElement(By.LinkText("Windows 10 Home"));
            hmwndws.Click();

            IWebElement adtoct = driver.FindElement(By.Id("PhysicalGoodIdentityBuyButton"));
            adtoct.Click();

            IWebElement shpcrt = driver.FindElement(By.Id("uhf-shopping-cart"));
            shpcrt.Click();

            IWebElement chkout = driver.FindElement(By.XPath("//*[@id='ember1113']"));
            chkout.Click();

            #region "commented code"

            //// IWebElement cart = driver.FindElement(By.Id("uhf-shopping-cart"));
            // cart.Click();
            // IWebElement seldev = driver.FindElement(By.Id("shellmenu_49"));
            // seldev.SendKeys(Keys.Enter);
            // IWebElement surfdev = driver.FindElement(By.Id("shellmenu_50"));
            // surfdev.SendKeys(Keys.Enter);
            // //IWebElement surfpro = driver.FindElement(By.Id("n10m1r1a2"));
            // IWebElement stopppt = driver.FindElement(By.XPath("//*[@id='coreui-hero-0vae7sh']"));
            // stopppt.Click();
            //IWebElement chssurfpro = driver.FindElement(By.XPath(" //*[@id='BuyBox']"));
            //chssurfpro.Click();
            //IWebElement adtc = driver.FindElement(By.XPath("//*[@id='PhysicalGoodIdentityBuyButton']"));
            //adtc.SendKeys(Keys.Enter);
            ////ember842
            //IWebElement rvchout = driver.FindElement(By.XPath("//*[@id='ember842']"));
            //rvchout.Click();
            //*[@id="BuyBox"]/div[3]/section/div[2]/div[6]/div/button[1]
            /* var iframes = driver.FindElements(By.TagName("iframe"));
             //IWebElement iframes;
             varctx.WriteLine(iframes.Count.ToString());
             // you can reach each frame on your site
             foreach (IWebElement iframe in  iframes)
             {

                 // switch to every frame
                 //driver.SwitchTo().Frame(iframe);

                 // now within the frame you can navigate like you are used to
                 varctx.WriteLine(iframe.TagName);

                 //System.out.println(driver.findElement(By.id("tinymce")).getText());
             }*/

            #endregion

        }
        [TestMethod]
        public void TestMethod2()
        {

            driver.Navigate().GoToUrl("http://www.starbucks.com");
            IWebElement Crdelm = driver.FindElement(By.XPath("//*[@id='nav_card']/a"));
            Crdelm.Click();
            Crdelm.SendKeys(Keys.Enter);
            IWebElement sndemil = driver.FindElement(By.LinkText("Give a Gift by Email"));
            sndemil.Click();
            // get to red cup 
            // IWebElement RCsct = driver.FindElement(By.XPath("//a[@href='/shop/card/egift/red-cup'])"));
            IWebElement RCsct = driver.FindElement(By.ClassName("label"));
            RCsct.Click(); 

        }
    }
}
