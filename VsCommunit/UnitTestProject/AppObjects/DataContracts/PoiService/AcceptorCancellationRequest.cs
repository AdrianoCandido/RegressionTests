using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi
{
    /// <summary>
    /// The AcceptorCancellationRequest message is sent by an acceptor (or its agent) to the acquirer (or its
    /// agent) , to request the cancellation of a successfully completed transaction. Cancellation should only
    /// occur before the transaction has been cleared.
    /// </summary>
    [XmlRoot(ElementName = "Document", Namespace = "urn:AcceptorCancellationRequestV02.1", IsNullable = false)]
    public partial class AcceptorCancellationRequest
    {
        /// <summary>
        /// Information related to the cancellation request.
        /// </summary>
        [XmlElement("AccptrCxlReq")]
        public AcceptorCancellationRequestData Data { get; set; }

        #region Nested types

        /// <summary>
        /// Information related to the cancellation request.
        /// </summary>
        [XmlRoot(ElementName = "AccptrCxlReq")]
        public partial class AcceptorCancellationRequestData
        {
            /// <summary>
            /// Cancellation request message management information
            /// </summary>

            [XmlElement("Hdr")]
            public Header Header { get; set; }

            /// <summary>
            /// Information related to the cancellation request.
            /// </summary>

            [XmlElement("CxlReq")]
            public CancellationRequestData CancellationRequest { get; set; }

            #region Nested types

            /// <summary>
            /// Information related to the cancellation request.
            /// </summary>
            [XmlRoot(ElementName = "CxlReq")]
            public partial class CancellationRequestData
            {
                /// <summary>
                /// Environment of the transaction
                /// </summary>

                [XmlElement("Envt")]
                public Environment Environment { get; set; }

                /// <summary>
                /// Cancellation transaction between an acceptor and an acquirer.
                /// </summary>

                [XmlElement("Tx")]
                public Transaction Transaction { get; set; }
            }

            /// <summary>
            /// Cancellation transaction between an acceptor and an acquirer
            /// </summary>
            public partial class Transaction
            {
                /// <summary>
                /// Flag indicating whether the transaction data must be captured or not in addition to the message process.
                /// </summary>
                [XmlElement("TxCaptr")]
                public bool TransactionCapture { get; set; }

                /// <summary>
                /// Identification of the transaction assigned by the POI (Point Of Interaction).
                /// </summary>
                //
                [XmlElement("TxId")]
                public TransactionIdentificationData TransactionIdentification { get; set; }

                /// <summary>
                /// Identification of the original transaction
                /// </summary>

                [XmlElement("OrgnlTx")]
                public OriginalTransaction OriginalTransaction { get; set; }

                /// <summary>
                /// Details of the transaction.
                /// </summary>

                [XmlElement("TxDtls")]
                public TransactionDetails TransactionDetails { get; set; }
            }

            /// <summary>
            /// Details of the transaction
            /// </summary>
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

                /// <summary>
                /// Reason for cancellation.
                /// </summary>
                [XmlElement("Rsn")]
                public string Reason { get; set; }
            }

            #endregion Nested types
        }

        /// <summary>
        /// Identification of the original transaction.
        /// </summary>
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

        #endregion Nested types

        /// <summary>
        /// Environment of the transaction
        /// </summary>
        public partial class Environment
        {
            /// <summary>
            /// Merchant performing the card payment transaction
            /// </summary>

            [XmlElement("Mrchnt")]
            public MerchantData Merchant { get; set; }

            [XmlElement("POI")]
            public AcceptorAuthorisationRequest.Poi Poi { get; set; }
        }

        /// <summary>
        /// Merchant performing the card payment transaction
        /// </summary>
        public partial class MerchantData
        {
            /// <summary>
            /// Identification of the merchant
            /// </summary>

            [XmlElement("Id")]
            public GenericIdentification Identification { get; set; }
        }

        /// <summary>
        /// Identification of the transaction assigned by the POI (Point Of Interaction).
        /// </summary>
        public partial class TransactionIdentificationData
        {
            /// <summary>
            /// Local date and time of the transaction assigned by the POI (Point Of Interaction).
            /// </summary>
            [XmlElement("TxDtTm")]
            public string TransactionDateTime { get; set; }

            /// <summary>
            /// Identification of the transaction that has to be unique for a time period.
            /// </summary>

            //
            [XmlElement("TxRef")]
            public string TransactionReference { get; set; }
        }
    }
}