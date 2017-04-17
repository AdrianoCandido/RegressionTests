using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi
{
    /// <summary>
    /// The AcceptorCompletionAdvice message is sent by an acceptor (or its agent) to notify the acquirer (or
    /// its agent) of the outcome of the payment at the acceptor, and to transfer the financial data of the trans-
    /// action to the acquirer (capture).
    /// </summary>
    [XmlRoot(ElementName = "Document", Namespace = "urn:AcceptorCompletionAdviceV02.1", IsNullable = false)]
    public partial class AcceptorCompletionAdvice
    {
        /// <summary>
        ///  Information related to the completion advice.
        /// </summary>

        [XmlElement("AccptrCmpltnAdvc")]
        public AcceptorCompletionAdviceData Data { get; set; }

        #region Nested types

        /// <summary>
        /// Information related to the completion advice.
        /// </summary>
        [XmlRoot(ElementName = "AccptrCmpltnAdvc")]
        public partial class AcceptorCompletionAdviceData
        {
            /// <summary>
            ///  Completion advice message management information
            /// </summary>

            [XmlElement("Hdr")]
            public Header Header { get; set; }

            /// <summary>
            /// Information related to the completion advice.
            /// </summary>

            [XmlElement("CmpltnAdvc")]
            public CompletionAdvice CompletionAdvice { get; set; }
        }

        /// <summary>
        ///  Information related to the completion advice
        /// </summary>
        [XmlRoot(ElementName = "CmpltnAdvc")]
        public partial class CompletionAdvice
        {
            /// <summary>
            /// Environment of the transaction.
            /// </summary>

            [XmlElement("Envt")]
            public Environment Environment { get; set; }

            /// <summary>
            /// Context in which the transaction is performed (payment and sale).
            /// </summary>
            [XmlElement("Cntxt")]
            public Context Context { get; set; }

            /// <summary>
            /// Card payment transaction between an acceptor and an acquirer
            /// </summary>

            [XmlElement("Tx")]
            public Transaction Transaction { get; set; }
        }

        /// <summary>
        /// Environment of the transaction
        /// </summary>
        [XmlRoot(ElementName = "Envt")]
        public partial class Environment
        {
            /// <summary>
            /// Merchant performing the card payment.
            /// </summary>

            [XmlElement("Mrchnt")]
            public Merchant Merchant { get; set; }

            /// <summary>
            /// Point of interaction (POI) performing the transaction.
            /// </summary>
            [XmlElement("POI")]
            public Poi Poi { get; set; }
        }

        /// <summary>
        /// Merchant performing the card payment.
        /// </summary>
        [XmlRoot(ElementName = "Mrchnt")]
        public class Merchant
        {
            /// <summary>
            /// Identification of the merchant.
            /// </summary>

            [XmlElement("Id")]
            public GenericIdentification Identification { get; set; }
        }

        /// <summary>
        /// Point of interaction (POI) performing the transaction.
        /// </summary>
        [XmlRoot(ElementName = "POI")]
        public class Poi
        {
            [XmlElement("Id")]
            public GenericIdentification Id { get; set; }
        }

        /// <summary>
        /// Context in which the transaction is performed (payment and sale).
        /// </summary>
        [XmlRoot(ElementName = "Cntxt")]
        public partial class Context
        {
            /// <summary>
            /// Context of the sale involving the card payment transaction.
            /// </summary>

            [XmlElement("SaleCntxt")]
            public SaleContext SaleContext { get; set; }
        }

        /// <summary>
        /// Context of the sale involving the card payment transaction.
        /// </summary>
        [XmlRoot(ElementName = "SaleCntxt")]
        public partial class SaleContext
        {
            /// <summary>
            /// Identification of the sale terminal (electronic cash register) or the sale system
            /// </summary>

            [XmlElement("SaleId")]
            public string SaleIdentification { get; set; }

            /// <summary>
            /// Identify a sale transaction assigned by the sale system.
            /// </summary>

            [XmlElement("SaleRefNb")]
            public string SaleReferenceNumber { get; set; }
        }

        /// <summary>
        /// Card payment transaction between an acceptor and an acquirer.
        /// </summary>
        [XmlRoot(ElementName = "Tx")]
        public partial class Transaction
        {
            /// <summary>
            ///  Identification of the original transaction.
            /// </summary>

            [XmlElement("OrgnlTx")]
            public OriginalTransaction OriginalTransaction { get; set; }

            /// <summary>
            /// Details of the transaction.
            /// </summary>

            [XmlElement("TxDtls")]
            public TransactionDetails TransactionDetails { get; set; }

            /// <summary>
            /// Unique identification of the transaction assigned by the POI (Point Of Interaction).
            /// </summary>
           //
            [XmlElement("TxId")]
            public TransactionIdentificationData TransactionIdentification { get; set; }
        }

        public partial class TransactionIdentificationData
        {
            /// <summary>
            ///
            /// </summary>
         //
            [XmlElement("TxDtTm")]
            public string TransactionDateTime { get; set; }

            /// <summary>
            ///
            /// </summary>
            //

            [XmlElement("TxRef")]
            public string TransactionReference { get; set; }
        }

        [XmlRoot(ElementName = "TxDtls")]
        public partial class TransactionDetails
        {
            /// <summary>
            /// Currency associated with the transaction.
            /// </summary>

            [XmlElement("Ccy")]
            public string Currency { get; set; }

            /// <summary>
            /// Total amount of the transaction.
            /// </summary>

            [XmlElement("TtlAmt")]
            public string TotalAmount { get; set; }
        }

        [XmlRoot(ElementName = "OrgnlTx")]
        public partial class OriginalTransaction
        {
            /// <summary>
            /// Identification of the transaction assigned by the recipient party for the initiating party.
            /// </summary>

            [XmlElement("RcptTxId")]
            public string RecipientTransactionIdentification { get; set; }

            /// <summary>
            /// Identification of the transaction assigned by the initiating party for the recipient party.
            /// </summary>

            [XmlElement("InitrTxId")]
            public string InitiatorTransactionIdentification { get; set; }
        }

        #endregion
    }
}