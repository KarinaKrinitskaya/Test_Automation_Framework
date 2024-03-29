﻿using TestAutomationFramework.Enums;
using NUnit.Framework;
using TestAutomationFramework.Utilities;

namespace TestAutomationFramework.Core.Helpers
{
    public static partial class TestSettings
    {
        public static TestContext TestContext { get; set; }

        #region RunSettingsMethods

        public static BrowserType Browser => EnumUtils.ParseEnum<BrowserType>(TestContext.Parameters.Get("Browser").ToString());

        public static string ScreenShotPath => TestContext.Parameters.Get("ScreenShotPath").ToString();

        public static string LogsPath => Path.Combine(TestContext.TestDirectory, @TestContext.Parameters.Get("LogsPath").ToString());

        public static TimeSpan WebDriverTimeOut => TimeSpan.FromSeconds(int.Parse(TestContext.Parameters.Get("WebDriverTimeOut").ToString()));

        public static string DefaultTimeOut => TestContext.Parameters.Get("WaitElementTimeOut").ToString();

        public static string ApplicationUrl => TestContext.Parameters.Get("ApplicationUrl").ToString();

        #endregion

    }
}
