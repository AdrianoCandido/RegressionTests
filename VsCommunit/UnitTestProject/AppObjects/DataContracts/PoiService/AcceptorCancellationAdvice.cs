using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi
{
    /// <summary>
    /// Message sent by an acceptor.
    /// </summary>
    [XmlRoot(ElementName = "Document", Namespace = "urn:AcceptorCancellationAdviceV02.1", IsNullable = false)]
    public class AcceptorCancellationAdvice
    {
        [XmlElement("AccptrCxlAdvc")]
        public AcceptorCancellationAdviceData Data { get; set; }

        [XmlRoot(ElementName = "AccptrCxlAdvc")]
        public class AcceptorCancellationAdviceData
        {
            /// <summary>
            /// Cancellation request message management information.
            /// </summary>
            [XmlElement("Hdr")]
            public Header Header { get; set; }

            /// <summary>
            /// Information related to the Cancellation request.
            /// </summary>

            [XmlElement("CxlAdvc")]
            public CancellationAdviceData AcceptorCancellationAdvice { get; set; }

            public class CancellationAdviceData
            {
                /// <summary>
                /// Environment of the transaction
                /// </summary>

                [XmlElement("Envt")]
                public EnviromentData Enviroment { get; set; }

                /// <summary>
                /// Card payment transaction for which the authorisation is requested.
                /// </summary>

                [XmlElement("Tx")]
                public TransactionData Transaction { get; set; }

                public class TransactionData
                {
                    /// <summary>
                    ///
                    /// </summary>

                    [XmlElement("TxId")]
                    public TransactionIdentificationData TransactionIdentification { get; set; }

                    /// <summary>
                    /// Details of the transaction.
                    /// </summary>

                    [XmlElement("TxDtls")]
                    public TransactionDetailsData TransactionDetails { get; set; }

                    [XmlElement("OrgnlTx")]
                    public OriginalTransactionData OriginalTransaction { get; set; }

                    public class TransactionIdentificationData
                    {
                        /// <summary>
                        ///
                        /// </summary>

                        [XmlElement("TxDtTm")]
                        public string TransactionDateTime { get; set; }

                        /// <summary>
                        ///
                        /// </summary>

                        [XmlElement("TxRef")]
                        public string TransactionReference { get; set; }
                    }

                    /// <summary>
                    /// Details of the transaction
                    /// </summary>
                    public class TransactionDetailsData
                    {
                        /// <summary>
                        /// Currency of original transaction.
                        /// </summary>

                        [XmlElement("Ccy")]
                        public string Currency { get; set; }

                        /// <summary>
                        /// Total amount of cancellation operation.
                        /// </summary>

                        [XmlElement("TtlAmt")]
                        public string TotalAmount { get; set; }
                    }

                    public class OriginalTransactionData
                    {
                        [XmlElement("RcptTxId")]
                        public string RecipientTransactionIdentification { get; set; }

                        /// <summary>
                        /// Identification of the transaction assigned by the initiating party for the recipient party.
                        /// </summary>

                        [XmlElement("InitrTxId")]
                        public string InitiatorTransactionIdentification { get; set; }
                    }
                }

                public class EnviromentData
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
            }
        }
    }
}