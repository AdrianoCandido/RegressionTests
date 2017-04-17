using Buy4.Services.Sdk.Models.Poi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PoiServiceRegressionTests.AppObjects.Communication;
using PoiServiceRegressionTests.AppObjects.DataContracts.PoiService;
using UnitTestProject1.Tests;

namespace PoiServiceRegressionTests.Tests.Mastercard.Authorization
{
    [TestClass]
    public class TicketPinOnline : BaseAuthorization
    {
        private SimpleAuthorizationRequest request;

        [TestInitialize]
        public void TestInitialize()
        {
            request = new SimpleAuthorizationRequest()
            {
                AccountType = AccountType.CreditCard,
                AmountInCents = 10,
                CardNumber = "6033425818367036000",
                EncryptedPinData = "FCC5538B06AD986A",
                EntryMode = CardDataEntryMode.Chip,
                ExpirationDate = "2016-09",
                FalbackIndicator = false,
                ICCRltdData = "5F2A02098682025800950500000480009A031607069C01009F02060000000005509F10200FA5E1A04080008200000000000000010FED82000000000000000000000000009F1A0200769F2608267092479409A0E19F2701809F34030203009F3602015B9F3303E0F0C89F3704EFA22A989F1E083531313931373838",
                InitiatorTransactionkey = "123456789",
                Installment = InstalmentType.Merchant,
                InstalmentQuantity = 10,
                KeySerialNumber = "254891235000BBE0002B",
                PrintLine = 0,
                SaleAffiliationKey = "DED2D2D08499462699B8E1628B599EE2",
                SequenceNumber = "2",
                SoftDescriptor = "TEST STONE",
                Track1 = null,
                Track2 = "6033425818367036000D25036000357080032",
                TransactionCapture = false,
                ValidationCode = null,
            };
        }

        [TestMethod]
        public void Authorize_TransactionCapture_true()
        {
            request.TransactionCapture = true;
            var result = HttpRequester.Post(request);
            Assert.IsFalse(result.Content.CompletionRequired);
        }

        [TestMethod]
        public void Authorize_TransactionCapture_false()
        {
            request.TransactionCapture = false;
            var result = HttpRequester.Post(request);
            Assert.IsTrue(result.Content.CompletionRequired);
        }
    }
}