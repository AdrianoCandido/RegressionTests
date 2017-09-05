using Buy4.Services.Sdk.Models.Poi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PoiServiceRegressionTests.AppObjects.Communication;
using PoiServiceRegressionTests.AppObjects.DataContracts.PoiService;
using PoiServiceRegressionTests.AppObjects.Serialization;

namespace PoiServiceRegressionTests
{
    [TestClass]
    public class SerializationValidation
    {
        //[TestMethod]
        //public void CreateAuthorizationRequest()
        //{
        //    XSerializer serializer = new XSerializer();

        //    var request = RequestFactory.CreateAuthorizationRequest(new SimpleAuthorizationRequest()
        //    {
        //        AccountType = AccountType.CreditCard,
        //        AmountInCents = 10,
        //        CardNumber = "5447315551882808",
        //        EncryptedPinData = "753944E87AFAF05B",
        //        EntryMode = CardDataEntryMode.Chip,
        //        ExpirationDate = "2016-09",
        //        FalbackIndicator = false,
        //        EmvData = "5F2A02098682025800950500802480009A031407109C01009F02060000000055559F10120114A000002A0000F82000000000000000FF9F1A0200769F260887FB9A39010A265B9F2701809F34034203009F360204339F3303E0F0C89F3704D0029F6B9F1E083343313139303539",
        //        InitiatorTransactionkey = "123456789",
        //        Installment = InstalmentType.Merchant,
        //        InstalmentQuantity = 10,
        //        KeySerialNumber = "5650494E54FFFF0001DF",
        //        PrintLine = 0,
        //        SaleAffiliationKey = "BFDB58AB9A8A48828C2647E18B7F1114",
        //        SequenceNumber = "0",
        //        SoftDescriptor = "TEST STONE",
        //        Track1 = null,
        //        Track2 = "5447315551882808D16092011407032735370",
        //        TransactionCapture = true,
        //        ValidationCode = null
        //    });

        //    Assert.AreEqual(request.Data.AuthorisationRequest.Environment.Card.PlainCardData.PAN, "5447315551882808");
        //    Assert.AreEqual(request.Data.AuthorisationRequest.Transaction.TransactionDetails.TotalAmount, "10");
        //    Assert.AreEqual(request.Data.AuthorisationRequest.Transaction.TransactionDetails.Installment.InstalmentType, Buy4.Services.Sdk.Models.Poi.InstalmentType.Merchant);
        //    Assert.AreEqual(request.Data.AuthorisationRequest.Transaction.TransactionDetails.Installment.TotalNumberOfPayments, "10");

        //    string xml = XSerializer.Serialize(request);

        //    var result = HttpRequester.Post<AcceptorAuthorisationResponse>(request, "http://172.19.55.50/Authorize");
        //}


         
    }
}