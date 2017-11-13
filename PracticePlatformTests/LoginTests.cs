using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlatformAutomation1;

namespace PlatformTests1
{
    [TestClass]
    public class LoginTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void Admin_User_Can_Login()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("karensouthwick").WithPassword("Exchange!6").Login();

            Assert.IsTrue(DashboardPage.IsAt, "Failed to login");
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
