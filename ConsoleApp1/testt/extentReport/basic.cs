using NUnit.Framework;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsQA
{
    class basic
    {
        [Test]
        public void df()
        {
            //string path = Path.Combine(Environment.CurrentDirectory, @"test-output\");
            var extent = new ExtentReports(@"C:\Users\mdalessio\source\repos\ConsoleApp1\ConsoleApp1\test-output\extent.html", true);

            // creates a toggle for the given test, adds all log events under it    

            var test = extent.StartTest("My First Test", "Sample description");

            // log(LogStatus, details)
            test.Log(LogStatus.Info, "This step shows usage of log(logStatus, details)");

            // report with snapshot
            //String img = test.AddScreenCapture("img-path");
            //test.Log(LogStatus.Info, "Image example: " + img);

            // end test
            extent.EndTest(test);

            // calling Flush writes everything to the log file
            extent.Flush();
        }
    }
}