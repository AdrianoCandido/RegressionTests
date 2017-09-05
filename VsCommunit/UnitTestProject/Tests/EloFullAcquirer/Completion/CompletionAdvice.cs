using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1.AppObjects.DataContracts;

namespace UnitTestProject1.Tests.Mastercard.Completion
{
    [TestClass]
    public class CompletionAdvice
    {
        private SimpleCompletionAdvice request;

        [TestInitialize]
        public void TestInitialize()
        {
            request = new SimpleCompletionAdvice()
            {
                AcquirerTransactionKey = "",
                Amount = 1
            };
        }
    }
}