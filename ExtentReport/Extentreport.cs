using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium.DevTools.V118.DOM;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testframework;

namespace Hotel
{
    public class ExtentReport : BasePage
    {

        public static ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(path);
        public static ExtentReports report = new ExtentReports();
        public static ExtentTest parent;
        public static ExtentTest childreport;

        public static void ParentLog(string parentTag)
        {
            parent = report.CreateTest(parentTag);
        }

        public static void ChildLog(string childnode)
        {
            childreport = parent.CreateNode(childnode);
        }

        public static void TestReportPassed(string filename, string Detailname)
        {
            //BasePage.screenshot(filename);
            childreport.Log(Status.Pass, (Detailname + ": Pass"), MediaEntityBuilder.CreateScreenCaptureFromPath(path + filename + ".jpeg").Build());
        }

        public static void TestReportFailed(string filename, string Detailname)
        {
            //BasePage.screenshot(filename);
            childreport.Log(Status.Fail, (Detailname + ": Fail"), MediaEntityBuilder.CreateScreenCaptureFromPath(path + filename + ".jpeg").Build());
        }

        public static void sys_info(string Browser)
        {
            report.AddSystemInfo("Oprating system", "windows 10");
            report.AddSystemInfo("HostName", "SeleniumPC");
            report.AddSystemInfo("Browser", Browser);
        }

        public static void Report()
        {
            report.AttachReporter(htmlReporter);
        }
        public static void flush()
        {
            report.Flush();
        }




    }
}