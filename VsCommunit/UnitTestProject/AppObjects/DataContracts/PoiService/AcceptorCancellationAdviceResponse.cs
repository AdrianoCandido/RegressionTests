using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi
{
    /// <summary>
    /// Message  sent by an acceptor.
    /// </summary>
    [XmlRoot(ElementName = "Document", Namespace = "urn:AcceptorCancellationAdviceResponseV02.1", IsNullable = false)]
    public partial class AcceptorCancellationAdviceResponse : ResponseBase
    {
        public AcceptorCancellationAdviceResponse()
        {
            this.Data = new AcceptorCancellationAdviceResponseData();
        }

        [XmlElement("AccptrCxlAdvcRspn")]
        public AcceptorCancellationAdviceResponseData Data { get; set; }

        [XmlRoot(ElementName = "AccptrCxlAdvcRspn")]
        public partial class AcceptorCancellationAdviceResponseData
        {
            public AcceptorCancellationAdviceResponseData()
            {
                this.CancellationAdviceResponse = new CancellationAdviceResponseData();
                this.Header = new Header();

                this.Header.MessageFunction = MessageFunctionCode.CancellationAdviceResponse;
            }

            /// <summary>
            /// Cancellation request message management information.
            /// </summary>
            [XmlElement("Hdr")]
            public Header Header { get; set; }

            /// <summary>
            /// Information related to the Cancellation request.
            /// </summary>
            [XmlElement("CxlAdvcRspn")]
            public CancellationAdviceResponseData CancellationAdviceResponse { get; set; }

            /// <summary>
            /// Information related to the authorisation request.
            /// </summary>
            public partial class CancellationAdviceResponseData
            {
                public CancellationAdviceResponseData()
                {
                    this.Environment = new Enviroment();
                    this.Transaction = new TransactionData();
                }

                [XmlElement("Envt")]
                public Enviroment Environment { get; set; }

                /// <summary>
                /// Cancellation transaction from an acceptor to the acquirer.
                /// </summary>
                [XmlElement("Tx")]
                public TransactionData Transaction { get; set; }

                public partial class TransactionData
                {
                    public TransactionData()
                    {
                        this.TransactionIdentification = new TransactionIdentificationData();
                    }

                    /// <summary>
                    /// Unique identification of the transaction by the POI.
                    /// </summary>
                    [XmlElement("TxId")]
                    public TransactionIdentificationData TransactionIdentification { get; set; }

                    /// <summary>
                    /// Result of a requested service
                    /// </summary>
                    [XmlElement("Rspn")]
                    public ResponseCode Response { get; set; }

                    //
                    //[XmlElement("RcptTxId")]
                    //public string RecipientTransactionIdentification { get; set; }

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
                        [XmlElement("TxRef")]
                        public string TransactionReference { get; set; }
                    }
                }
            }
        }

        public partial class Enviroment
        {
            public Enviroment()
            {
                this.Merchant = new GenericIdentification();
            }

            /// <summary>
            /// Merchant performing the card payment.
            /// </summary>
            [XmlElement("Mrchnt")]
            public GenericIdentification Merchant { get; set; }
        }
    }
}