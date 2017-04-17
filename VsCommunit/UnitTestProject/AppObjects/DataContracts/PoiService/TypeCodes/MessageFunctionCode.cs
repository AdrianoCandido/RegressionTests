using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi
{
    /// <summary>
    /// Identifies the type of process related to the message.
    /// </summary>
    public enum MessageFunctionCode
    {
        /// <summary>
        /// Request for authorisation without financial capture.
        /// </summary>
        [XmlEnum("AUTQ")]
        AuthorisationRequest = 0,

        /// <summary>
        /// Response for authorisation without financial capture.
        /// </summary>
        [XmlEnum("AUTP")]
        AuthorisationResponse = 1,

        /// <summary>
        /// Request for authorisation with financial capture.
        /// </summary>
        [XmlEnum("FAUQ")]
        FinancialAuthorisationRequest = 2,

        /// <summary>
        /// Response for authorisation with financial capture.
        /// </summary>
        [XmlEnum("FAUP")]
        FinancialAuthorisationResponse = 3,

        /// <summary>
        /// Advice for completion without financial capture
        /// </summary>
        [XmlEnum("CMPV")]
        CompletionAdvice = 4,

        /// <summary>
        /// Advice response for completion without financial capture
        /// </summary>
        [XmlEnum("CMPK")]
        CompletionAdviceResponse = 5,

        /// <summary>
        /// Advice for completion with financial capture.
        /// </summary>
        [XmlEnum("FCMV")]
        FinancialCompletionAdvice = 6,

        /// <summary>
        /// Advice response for completion with financial capture.
        /// </summary>
        [XmlEnum("FCMK")]
        FinancialCompletionAdviceResponse = 7,

        /// <summary>
        /// Advice for reversal without financial capture.
        /// </summary>
        [XmlEnum("RVRA")]
        ReversalAdvice = 8,

        /// <summary>
        /// Advice response for reversal without financial capture.
        /// </summary>
        [XmlEnum("RVRR")]
        ReversalAdviceResponse = 9,

        /// <summary>
        /// Advice for reversal with financial capture.
        /// </summary>
        [XmlEnum("FRVA")]
        FinancialReversalAdvice = 10,

        /// <summary>
        /// Advice response for reversal with financial capture.
        /// </summary>
        [XmlEnum("FRVR")]
        FinancialReversalAdviceResponse = 11,

        /// <summary>
        /// Request for cancellation.
        /// </summary>
        [XmlEnum("CCAQ")]
        CancellationRequest = 12,

        /// <summary>
        /// Response for cancellation.
        /// </summary>
        [XmlEnum("CCAP")]
        CancellationResponse = 13,

        /// <summary>
        /// Advice for cancellation.
        /// </summary>
        [XmlEnum("CCAV")]
        CancellationAdvice = 14,

        /// <summary>
        /// Advice response for cancellation.
        /// </summary>
        [XmlEnum("CCAK")]
        CancellationAdviceResponse = 15,

        /// <summary>
        /// Request for diagnostic.
        /// </summary>
        [XmlEnum("DGNP")]
        DiagnosticRequest = 16,

        /// <summary>
        /// Response for diagnostic.
        /// </summary>
        [XmlEnum("DGNQ")]
        DiagnosticResponse = 17,

        /// <summary>
        /// Request for reconciliation.
        /// </summary>
        [XmlEnum("RCLQ")]
        ReconciliationRequest = 18,

        /// <summary>
        /// Response for reconciliation.
        /// </summary>
        [XmlEnum("RCLP")]
        ReconciliationResponse = 19,

        /// <summary>
        /// Reject a request or an advice.
        /// </summary>
        [XmlEnum("RJCT")]
        AcceptorRejection = 20,

        /// <summary>
        /// Request for Transaction Report
        /// </summary>
        [XmlEnum("TSRR")]
        TransactionStatusReportRequest = 21,

        /// <summary>
        /// Response for Transaction Report
        /// </summary>
        [XmlEnum("TSRP")]
        TransactionStatusReportResponse = 22,
    }
}