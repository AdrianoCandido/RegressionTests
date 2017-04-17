namespace PoiServiceRegressionTests.AppObjects.DataContracts.PoiService
{
    public class SimpleAuthorizationResponse
    {
        public string Response { get; set; }
        public string ResponseReason { get; set; }
        public string AuthorisationCode { get; set; }
        public bool CompletionRequired { get; set; }
        public string ICCRltdData { get; set; }
        public string AccountType { get; set; }
        public string TransactionDateTime { get; set; }
        public string TransactionReference { get; set; }
        public string RecipientTransactionIdentification { get; set; }
    }
}