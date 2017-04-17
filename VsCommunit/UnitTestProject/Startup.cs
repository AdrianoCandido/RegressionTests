using Dlp.Buy4.AuthorizationProvider.ServiceLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ServiceModel;
using System.Threading;

namespace PoiServiceRegressionTests.AppObjects
{
    [TestClass]
    public class Startup
    {
        [TestMethod]
        public void test()
        {
        }

        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            ServiceHost serviceHost = new ServiceHost(typeof(Provider));
            serviceHost.Open();
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
           // Thread.Sleep(TimeSpan.FromMinutes(2));
        }
    }
}