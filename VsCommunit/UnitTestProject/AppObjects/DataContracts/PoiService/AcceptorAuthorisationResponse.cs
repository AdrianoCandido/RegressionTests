using Buy4.Services.Sdk.Models.Poi.TypeCodes;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi
{
    /// <summary>
    /// Information related to the response of the authorisation.
    /// </summary>
    [XmlRoot(ElementName = "Document", Namespace = "urn:AcceptorAuthorisationResponseV02.1", IsNullable = false)]
    public partial class AcceptorAuthorisationResponse : ResponseBase
    {
        public AcceptorAuthorisationResponse()
        {
            this.Data = new AcceptorAuthorisationResponseData();
        }

        [XmlElement("AccptrAuthstnRspn")]
        public AcceptorAuthorisationResponseData Data { get; set; }

        [XmlRoot(ElementName = "AccptrAuthstnRspn")]
        public partial class AcceptorAuthorisationResponseData
        {
            public AcceptorAuthorisationResponseData()
            {
                this.Header = new Header();

                this.Header.MessageFunction = MessageFunctionCode.AuthorisationResponse;
            }

            #region Properties

            ///// <summary>
            ///// Authorisation response message management information
            ///// </summary>

            [XmlElement("Hdr")]
            public Header Header { get; set; }

            ///// <summary>
            ///// Information related to the response of the authorisation.
            ///// </summary>

            [XmlElement("AuthstnRspn")]
            public AuthorisationResponseData AuthorisationResponse { get; set; }

            #endregion Properties
        }

        /// <summary>
        /// Set of actions to be performed by the POI (Point Of Interaction) system.
        /// </summary>
        public partial class Action
        {
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

            ///// <summary>
            ///// Electronic signature of the message to display or print.
            ///// </summary>
            //
            //[XmlElement("MsgCnttSgntr")]
            //public string MessageContentSignature { get; set; }
        }

        /// <summary>
        /// Response to an authorisation request
        /// </summary>
        public partial class ResponseToAuthorisationData
        {
            /// <summary>
            /// Result of the transaction
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
        /// Unique identification of the transaction assigned by the POI (Point Of Interaction).
        /// </summary>
        public partial class TransactionIdentification
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

        /// <summary>
        /// Outcome of the authorisation, and actions to perform.
        /// </summary>
        public partial class AuthorisationResultData
        {
            /// <summary>
            /// Response to an authorisation request
            /// </summary>

            [XmlElement("RspnToAuthstn")]
            public ResponseToAuthorisationData ResponseToAuthorisation { get; set; }

            /// <summary>
            /// Value assigned by the authorising party.
            /// </summary>
            [XmlElement("AuthstnCd")]
            public string AuthorisationCode { get; set; }

            /// <summary>
            /// Indicates whether the acquirer requires a further exchange completion after the completion of the transaction
            /// </summary>
            [XmlElement("CmpltnReqrd")]
            public bool CompletionRequired { get; set; }
        }

        /// <summary>
        /// Information related to the response of the authorisation.
        /// </summary>
        public partial class AuthorisationResponseData
        {
            #region Properties

            /// <summary>
            /// Environment of the transaction.
            /// </summary>
            [XmlElement("Envt")]
            public Environment Environment { get; set; }

            /// <summary>
            /// Authorisation of a card payment transaction between an acceptor and an acquirer.
            /// </summary>
            [XmlElement("Tx")]
            public TransactionData Transaction { get; set; }

            /// <summary>
            /// Authorisation response from the acquirer.
            /// </summary>
            [XmlElement("TxRspn")]
            public TransactionResponseData TransactionResponse { get; set; }

            #endregion Properties
        }

        /// <summary>
        /// Environment of the transaction.
        /// </summary>
        public class Environment
        {
            /// <summary>
            /// Definition: Payment card performing the transaction.
            /// </summary>
            [XmlElement("Card")]
            public Card Card { get; set; }

            /// <summary>
            /// Identification of the merchant.
            /// </summary>
            [XmlElement("MrchntId")]
            public GenericIdentification MerchantIdentification { get; set; }

            /// <summary>
            /// Identification of the POI performing the transaction
            /// </summary>
            [XmlElement("POIId")]
            public GenericIdentification POIIdentification { get; set; }
        }

        public partial class Card
        {
            /// <summary>
            /// Masked PAN to be printed on payment receipts or displayed to the cardholder. Masked digits
            /// may be absent or replaced by another character as '*'.
            /// </summary>
            [XmlElement("MskdPAN")]
            public string MaskedPAN { get; set; }

            /// <summary>
            /// Brand name of the card.
            /// </summary>
            [XmlElement("CardBrand")]
            public string CardBrand { get; set; }

            /// <summary>
            /// Additional card issuer specific data.
            /// </summary>
            [XmlElement("AddtlCardData")]
            public string AdditionalCardData { get; set; }
        }

        /// <summary>
        ///  Detail of the transaction transported.
        /// </summary>
        public partial class TransactionDetails
        {
            /// <summary>
            /// Currency associated with the transaction.
            /// </summary>
            [XmlElement("Ccy")]
            public uint Currency { get; set; }

            /// <summary>
            /// Total amount of the transaction.
            /// </summary>

            [XmlElement("TtlAmt")]
            public string TotalAmount { get; set; }

            /// <summary>
            /// Data related to an integrated circuit card application
            /// </summary>

            [XmlElement("ICCRltdData")]
            public string ICCRelatedData { get; set; }

            /// <summary>
            /// Type of cardholder account used for the transaction.
            /// </summary>
            [XmlElement("AcctTp")]
            public AccountType AccountType { get; set; }

            /// <summary>
            /// Transaction authorisation deadline to complete the related payment.
            /// </summary>

            [XmlElement("VldtyDt")]
            public string ValidityDate { get; set; }

            /// <summary>
            /// Detailed amounts associated with the total amount of transaction.
            /// </summary>
            [XmlElement("DtldAmt")]
            public DetailedAmount DetailedAmount { get; set; }
        }

        /// <summary>
        /// Authorisation of a card payment transaction between an acceptor and an acquirer.
        /// </summary>
        public partial class TransactionResponseData
        {
            /// <summary>
            /// Outcome of the authorisation, and actions to perform.
            /// </summary>
            [XmlElement("AuthstnRslt")]
            public AuthorisationResultData AuthorisationResult { get; set; }

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
        /// Authorisation of a card payment transaction between an acceptor and an acquirer.
        /// </summary>
        public partial class TransactionData
        {
            /// <summary>
            /// Identification of the transaction assigned by the POI (Point Of Interaction).
            /// </summary>

            [XmlElement("TxId")]
            public TransactionIdentification TransactionIdentification { get; set; }

            /// <summary>
            /// Identification of the transaction assigned by the recipient party for the initiating party.
            /// </summary>
            [XmlElement("RcptTxId")]
            public string RecipientTransactionIdentification { get; set; }

            [XmlElement("TxDtls")]
            public TransactionDetails TransactionDetails { get; set; }
        }

        public partial class DetailedAmount
        {
        }
    }
}