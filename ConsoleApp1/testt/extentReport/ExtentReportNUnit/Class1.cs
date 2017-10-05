﻿using NUnit.Framework;
using NUnit.Framework.Interfaces;
using RelevantCodes.ExtentReports;

internal class ExtentManager
{
    private static readonly ExtentReports _instance =
        new ExtentReports(@"C:\Users\mdalessio\source\repos\ConsoleApp1\ConsoleApp1\test-output\extent.html", DisplayOrder.OldestFirst);

    static ExtentManager() { }

    private ExtentManager() { }

    public static ExtentReports Instance
    {
        get
        {
            return _instance;
        }
    }
}

public abstract class ExtentBase
{
    protected ExtentReports extent;
    protected ExtentTest test;

    [OneTimeSetUp]
    public void FixtureInit()
    {
        extent = ExtentManager.Instance;
        extent.LoadConfig(@"C:\Users\mdalessio\source\repos\ConsoleApp1\ConsoleApp1\" + "extent-config.xml");
    }

    [TearDown]
    public void TearDown()
    {

        var status = TestContext.CurrentContext.Result.Outcome.Status;
        var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace)
                ? ""
                : string.Format("<pre>{0}</pre>", TestContext.CurrentContext.Result.StackTrace);
        LogStatus logstatus;

        switch (status)
        {
            case TestStatus.Failed:
                logstatus = LogStatus.Fail;
                break;
            case TestStatus.Inconclusive:
                logstatus = LogStatus.Warning;
                break;
            case TestStatus.Skipped:
                logstatus = LogStatus.Skip;
                break;
            default:
                logstatus = LogStatus.Pass;
                break;
        }

        test.Log(logstatus, "Test ended with " + logstatus + stacktrace);

        extent.EndTest(test);
        extent.Flush();
    }
}

[TestFixture]
public class SingleLogTests : ExtentBase
{
    [Test]
    public void IntentionalFailure()
    {
        test = extent.StartTest("PassTest");
        test.Log(LogStatus.Pass, "Pass");

        // intentional failure 
        Assert.True(test.GetCurrentStatus() == LogStatus.Fail);
    }
}