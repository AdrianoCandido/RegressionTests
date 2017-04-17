using Buy4.Services.Sdk.Models.Poi;

namespace PoiServiceRegressionTests.AppObjects.DataContracts.PoiService
{
    public enum CardDataEntryMode { Magnetic, Ecommerce, Chip, ContactLess }


    /// <summary>
    /// Object to simplify authorization request parameters.
    /// </summary>
    public class SimpleAuthorizationRequest
    {
        #region Public Properties

        public AccountType AccountType { get; set; }
        public long AmountInCents { get; set; }
        public string CardNumber { get; set; }
        public string EncryptedPinData { get; set; }
        public CardDataEntryMode EntryMode { get; set; }
        public string ExpirationDate { get; set; }
        public bool FalbackIndicator { get; set; }
        public string ICCRltdData { get; set; }
        public string InitiatorTransactionkey { get; set; }
        public InstalmentType Installment { get; set; }
        public int InstalmentQuantity { get; set; }
        public string KeySerialNumber { get; set; }
        public int PrintLine { get; set; }
        public string SaleAffiliationKey { get; set; }
        public string SequenceNumber { get; set; }
        public string SoftDescriptor { get; set; }
        public string Track1 { get; set; }
        public string Track2 { get; set; }
        public bool TransactionCapture { get; set; }
        public string ValidationCode { get; set; }

        #endregion
    }
}