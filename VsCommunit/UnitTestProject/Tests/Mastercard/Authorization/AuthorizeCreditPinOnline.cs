using Buy4.Services.Sdk.Models.Poi;
using Dlp.Buy4.AuthorizationProvider.Core.Operations;
using Dlp.Buy4.AuthorizationProvider.ServiceLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PoiServiceRegressionTests.AppObjects.Communication;
using PoiServiceRegressionTests.AppObjects.DataContracts.PoiService;
using System;

namespace PoiServiceRegressionTests.Tests.Mastercard.Authorization
{
    [TestClass]
    public class AuthorizeCreditPinOnline
    {
        private SimpleAuthorizationRequest request;

        [TestInitialize]
        public void TestInitialize()
        {
            Provider.InterceptAuthorize += ProvideInterceptAuthorize;

            request = new SimpleAuthorizationRequest()
            {
                AccountType = AccountType.CreditCard,
                AmountInCents = 10,
                CardNumber = "5447315551882808",
                EncryptedPinData = "753944E87AFAF05B",
                EntryMode = CardDataEntryMode.Chip,
                ExpirationDate = "2016-09",
                FalbackIndicator = false,
                ICCRltdData = "5F2A02098682025800950500802480009A031407109C01009F02060000000055559F10120114A000002A0000F82000000000000000FF9F1A0200769F260887FB9A39010A265B9F2701809F34034203009F360204339F3303E0F0C89F3704D0029F6B9F1E083343313139303539",
                InitiatorTransactionkey = "123456789",
                Installment = InstalmentType.Merchant,
                InstalmentQuantity = 10,
                KeySerialNumber = "5650494E54FFFF0001DF",
                PrintLine = 0,
                SaleAffiliationKey = "DED2D2D08499462699B8E1628B599EE2",
                SequenceNumber = "0",
                SoftDescriptor = "TEST STONE",
                Track1 = null,
                Track2 = "5447315551882808D16092011407032735370",
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

        private AuthorizationResponse ProvideInterceptAuthorize(AuthorizationRequest arg)
        {
            return new AuthorizationResponse()
            {
                AcquirerDateTime = DateTime.UtcNow,
                ActionCode = "0000",
                AmountAuthorized = 1,
                AmountOriginal = 1,
                AquirerTransactionKey = "11111111111111",
                AuthorizationId = "12322",
                BalanceAmount = 1,
                IccRelatedData = "111111",
                IsPartial = false,
                PaymentSchemeId = 1,
                Success = true
            };
        }
    }
}