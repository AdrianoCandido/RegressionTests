using Buy4.Services.Sdk.Models.Poi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PoiServiceRegressionTests.AppObjects.Communication;
using PoiServiceRegressionTests.AppObjects.DataContracts.PoiService;
using UnitTestProject1.Tests;

namespace PoiServiceRegressionTests.Tests.Mastercard.Authorization
{
    [TestClass]
    public class AuthorizeCreditPinOnline : BaseAuthorization
    {
        public AuthorizeCreditPinOnline() : base()
        {
            Request = new SimpleAuthorizationRequest()
            {
                // Set Amount 3,00 R$
                AmountInCents = 400,
                AccountType = AccountType.Checking,
                CardNumber = "5067209999999999",

                // Not used
                // EncryptedPinData = "753944E87AFAF05B",

                EntryMode = CardDataEntryMode.Chip,
                ExpirationDate = "2016-09",

                // Set fall-back indicator on.
                FalbackIndicator = false,

                // Not used
                EmvData = "5F2A02098682025800950500802480009A031407109C01009F02060000000055559F10120114A000002A0000F82000000000000000FF9F1A0200769F260887FB9A39010A265B9F2701809F34034203009F360204339F3303E0F0C89F3704D0029F6B9F1E083343313139303539",

                InitiatorTransactionkey = "123456789",
                Installment = InstalmentType.None,
                InstalmentQuantity = 0,

                // Not used
                //KeySerialNumber = "5650494E54FFFF0001DF",
                PrintLine = 0,
                SaleAffiliationKey = "87B46724838745D8B362A3176E17E806",
                SequenceNumber = "0",
                SoftDescriptor = "TEST STONE",
                Track1 = null,
                Track2 = "5067209999999999D16092011407032735370",
                TransactionCapture = false,
                ValidationCode = null,
            };
        }

        [TestMethod]
        public void CT_UC0000_004()
        {
            Request.TransactionCapture = true;

            var result = HttpRequester.Post(Request);

            Assert.AreEqual("0000", result.Content.ResponseReason);
            Assert.IsFalse(result.Content.CompletionRequired);
        }
    }
}