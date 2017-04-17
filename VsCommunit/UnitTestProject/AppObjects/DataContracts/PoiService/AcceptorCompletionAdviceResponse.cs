using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi
{
    /// <summary>
    /// The AcceptorCompletionAdviceResponse message is sent by the acquirer (or its agent)
    /// to acknowledge the acceptor (or its agent) of the outcome of the payment transaction,
    /// and the transfer the financial data of the transaction contained in the completion advice.
    /// </summary>
    [XmlRoot(ElementName = "Document", Namespace = "urn:AcceptorCompletionAdviceResponseV02.1", IsNullable = false)]
    public partial class AcceptorCompletionAdviceResponse : ResponseBase
    {
        public AcceptorCompletionAdviceResponse()
        {
            this.Data = new AcceptorCompletionAdviceResponseData();
        }

        /// <summary>
        /// Information related to the completion advice response
        /// </summary>
        [XmlElement("AccptrCmpltnAdvcRspn")]
        public AcceptorCompletionAdviceResponseData Data { get; set; }

        #region Nested types

        [XmlRoot(ElementName = "AccptrCmpltnAdvcRspn")]
        public partial class AcceptorCompletionAdviceResponseData
        {
            public AcceptorCompletionAdviceResponseData()
            {
                this.CompletionAdviceResponse = new CompletionAdviceResponse();
                this.Header = new Header();
                this.Header.MessageFunction = MessageFunctionCode.CompletionAdviceResponse;
            }

            /// <summary>
            /// Completion advice response message management information.
            /// </summary>
            [XmlElement("Hdr")]
            public Header Header { get; set; }

            [XmlElement("CmpltnAdvcRspn")]
            public CompletionAdviceResponse CompletionAdviceResponse { get; set; }
        }

        public class CompletionAdviceResponse
        {
            public CompletionAdviceResponse()
            {
                this.Environment = new Enviroment();
                this.Transaction = new Transaction();
            }

            /// <summary>
            ///  Environment of the transaction.
            /// </summary>
            [XmlElement("Envt")]
            public Enviroment Environment { get; set; }

            /// <summary>
            /// Card payment transaction between an acceptor and an acquirer.
            /// </summary>

            [XmlElement("Tx")]
            public Transaction Transaction { get; set; }
        }

        public partial class Transaction
        {
            public Transaction()
            {
                this.TransactionIdentification = new TransactionIdentification();
            }

            /// <summary>
            /// Unique identification of the transaction by the POI (Point Of Interaction).
            /// </summary>

            [XmlElement("TxId")]
            public TransactionIdentification TransactionIdentification { get; set; }

            /// <summary>
            /// Result of the transaction.
            /// </summary>
            [XmlElement("Rspn")]
            public ResponseCode Response { get; set; }
        }

        public partial class TransactionIdentification
        {
            /// <summary>
            ///  Local date and time of the transaction assigned by the POI (Point Of Interaction).
            /// </summary>

            [XmlElement("TxDtTm")]
            public string TransactionDateTime { get; set; }

            /// <summary>
            ///  Identification of the transaction that has to be unique for a time period
            /// </summary>

            [XmlElement("TxRef")]
            public string TransactionReference { get; set; }
        }

        public partial class Enviroment
        {
            public Enviroment()
            {
                // this.AcquirerIdentification = new GenericIdentification();
                this.MerchantIdentification = new GenericIdentification();
                //  this.POIIdentification = new GenericIdentification();
            }

            [XmlElement("AcqrrId")]
            public GenericIdentification AcquirerIdentification { get; set; }

            /// <summary>
            /// Identification of the POI (Point Of Interaction) performing the transaction
            /// </summary>
            [XmlElement("POIId")]
            public GenericIdentification POIIdentification { get; set; }

            /// <summary>
            /// Merchant performing the card payment.
            /// </summary>
            [XmlElement("MrchntId")]
            public GenericIdentification MerchantIdentification { get; set; }
        }

        #endregion
    }
}