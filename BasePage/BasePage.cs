using Allure.Net.Commons;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testframework
{
    public class BasePage
    {
        public static IWebDriver driver;
        public static string path = @"C:\Users\Farwa\source\repos\testframework\ScreenShot\";


        public static void SeleniumInit(string url)
        {
            driver= new ChromeDriver();
            driver.Url=url;
        }

        public static void Maximuize()
        {
            driver.Manage().Window.Maximize();
        }

        public static void Write(By by, string text, string detailname)
        { 
            driver.FindElement(by).SendKeys(text);
            TakeScreenshot(detailname);
            //screenshot(filename);
        }

        public static void click(By by)  
        {       
            driver.FindElement(by).Click();
        }     

        public static void enter( By by)
        {
            driver.FindElement (by).SendKeys(Keys.Enter); 
        }

        public static void Tab(By by)
        {
            driver.FindElement(by).SendKeys(Keys.Tab);      
        }

        //public static void screenshot(string filename)
        //{
        //    Screenshot user_image = ((ITakesScreenshot)driver).GetScreenshot();
        //    user_image.SaveAsFile(path + filename + ".jpeg");

        //}
        public static void TakeScreenshot(string stepDetail)
        {
            string path = @"C:\Users\Farwa\source\repos\testframework\ScreenShot\" + "TestExecLog_" + DateTime.Now.ToString("yyyyMMddHHmmss");
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(path);
            AllureLifecycle.Instance.AddAttachment(stepDetail, "image/png", path);
        }

        public static void assertion_text(By by,string expected)
        {
            string actual = driver.FindElement(by).Text;
            Assert.AreEqual(expected, actual);
        }





    }
}
