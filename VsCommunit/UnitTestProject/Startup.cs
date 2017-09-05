using Dlp.Buy4.AuthorizationProvider.ServiceLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ServiceModel;

namespace PoiServiceRegressionTests.AppObjects
{
    [TestClass]
    public class Startup
    {
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