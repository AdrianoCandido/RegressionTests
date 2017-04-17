using Buy4.Services.Sdk.Models.Poi.TypeCodes;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi
{
    /// <summary>
    /// The AcceptorCancellationResponse message is sent by the acquirer (or its agent) to an acceptor (or its
    /// agent), to return the outcome of the cancellation request. If the response is positive, the acquirer has
    /// voided the financial data from the captured transaction.
    /// </summary>
    [XmlRoot(ElementName = "Document", Namespace = "urn:AcceptorCancellationResponseV02.1", IsNullable = false)]
    public partial class AcceptorCancellationResponse : ResponseBase
    {
        public AcceptorCancellationResponse()
        {
            this.Data = new AcceptorCancellationResponseData();
        }

        /// <summary>
        /// Information related to the cancellation response.
        /// </summary>
        [XmlElement("AccptrCxlRspn")]
        public AcceptorCancellationResponseData Data { get; set; }

        #region Nested types

        /// <summary>
        /// Information related to the cancellation response
        /// </summary>
        [XmlRoot(ElementName = "AccptrCxlRspn")]
        public partial class AcceptorCancellationResponseData
        {
            public AcceptorCancellationResponseData()
            {
                this.Header = new Header();
                this.Header.MessageFunction = MessageFunctionCode.CancellationResponse;
                this.CancellationResponse = new CancellationResponse();
            }

            /// <summary>
            /// Cancellation response message management information
            /// </summary>
            [XmlElement("Hdr")]
            public Header Header { get; set; }

            /// <summary>
            /// Information related to the cancellation response.
            /// </summary>
            [XmlElement("CxlRspn")]
            public CancellationResponse CancellationResponse { get; set; }
        }

        public partial class CancellationResponse
        {
            public CancellationResponse()
            {
                this.Environment = new Environment();
                this.Transaction = new Transaction();
                this.TransactionResponse = new TransactionResponse();
            }

            /// <summary>
            /// Environment of the transaction
            /// </summary>

            [XmlElement("Envt")]
            public Environment Environment { get; set; }

            /// <summary>
            /// Response from the acquirer to the cancellation transaction.
            /// </summary>
            [XmlElement("TxRspn")]
            public TransactionResponse TransactionResponse { get; set; }

            /// <summary>
            /// Cancellation transaction between an acceptor and an acquirer.
            /// </summary>

            [XmlElement("Tx")]
            public Transaction Transaction { get; set; }
        }

        public class Transaction
        {
            public Transaction()
            {
                this.TransactionDetails = new TransactionDetails();
                this.TransactionIdentification = new TransactionIdentificationData();
            }

            /// <summary>
            /// Identification of the transaction assigned by the POI (Point Of Interaction).
            /// </summary>

            [XmlElement("TxId")]
            public TransactionIdentificationData TransactionIdentification { get; set; }

            /// <summary>
            /// Identification of the transaction assigned by the recipient party for the initiating party.
            /// </summary>

            [XmlElement("RcptTxId")]
            public string RecipientTransactionIdentification { get; set; }

            /// <summary>
            /// Details of the transaction.
            /// </summary>

            [XmlElement("TxDtls")]
            public TransactionDetails TransactionDetails { get; set; }
        }

        public partial class Action
        {
            public Action()
            {
                this.MessageToPresent = new MessageToPresentData();
            }

            /// <summary>
            /// Type of action to be performed by the POI (Point Of Interaction) system
            /// </summary>

            [XmlElement("ActnTp")]
            public ActionTypeCode ActionType { get; set; }

            /// <summary>
            /// Message to be displayed to the cardholder or the cashier.
            /// </summary>
            [XmlElement("MsgToPres")]
            public MessageToPresentData MessageToPresent { get; set; }
        }

        public partial class MessageToPresentData
        {
            /// <summary>
            /// Destination of the message to be displayed or printed.
            /// </summary>

            [XmlElement("MsgDstn")]
            public UserInterfaceCode MessageDestination { get; set; }

            /// <summary>
            /// Text or graphic data to be display or printed to the cardholder or the cashier.
            /// </summary>

            [XmlElement("MsgCntt")]
            public string MessageContent { get; set; }
        }

        public partial class TransactionResponse
        {
            public TransactionResponse()
            {
                this.AuthorisationResult = new AuthorisationResult();
                this.Action = new List<Action>();
            }

            /// <summary>
            /// Outcome of the authorisation, and actions to perform.
            /// </summary>
            [XmlElement("AuthstnRslt")]
            public AuthorisationResult AuthorisationResult { get; set; }

            /// <summary>
            /// Set of actions to be performed by the POI (Point Of Interaction) system.
            /// </summary>
            [XmlElement("Actn")]
            public List<Action> Action { get; set; }

            /// <summary>
            /// Balance of the account, related to the payment.
            /// </summary>
            [XmlElement("Bal")]
            public Balance Balance { get; set; }
        }

        /// <summary>
        /// Balance of the account, related to the payment
        /// </summary>
        public partial class Balance
        {
            /// <summary>
            /// Amount of the account
            /// </summary>
            [XmlElement("Amt")]
            public string Amount { get; set; }
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
        }

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

        public partial class AuthorisationResult
        {
            public AuthorisationResult()
            {
                this.ResponseToAuthorisation = new ResponseToAuthorisation();
            }

            /// <summary>
            /// Response to an authorisation request.
            /// </summary>
            [XmlElement("RspnToAuthstn")]
            public ResponseToAuthorisation ResponseToAuthorisation { get; set; }

            /// <summary>
            /// Indicates whether the acquirer requires a further exchange completion after the completion of the transaction.
            /// </summary>
            [XmlElement("CmpltnReqrd")]
            public bool CompletionRequired { get; set; }

            /// <summary>
            /// Value assigned by the authorising party.
            /// </summary>
            [XmlElement("AuthstnCd")]
            public string AuthorisationCode { get; set; }
        }

        public partial class ResponseToAuthorisation
        {
            /// <summary>
            /// Result of the transaction.
            /// </summary>
            [XmlElement("Rspn")]
            public ResponseCode Response { get; set; }

            /// <summary>
            /// Detailed result of the transaction.
            /// </summary>
            [XmlElement("RspnRsn")]
            public string ResponseReason { get; set; }
        }

        /// <summary>
        /// Environment of the transaction
        /// </summary>
        public partial class Environment
        {
            public Environment()
            {
                this.MerchantIdentification = new GenericIdentification();
            }

            /// <summary>
            /// Merchant performing the card payment transaction
            /// </summary>

            [XmlElement("MrchntId")]
            public GenericIdentification MerchantIdentification { get; set; }
        }

        #endregion Nested types
    }
}