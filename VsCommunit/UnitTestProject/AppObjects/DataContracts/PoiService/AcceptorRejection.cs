using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi
{
    /// <summary>
    /// AcceptorRejection message is sent by the acquirer (or its agent) to reject a message request or
    /// advice sent by an acceptor (or its agent), to indicate that the received message could not be processed.
    /// </summary>
    [DataContract]
    [XmlRoot(ElementName = "Document", Namespace = "urn:AcceptorRejectionV02.1", IsNullable = false)]
    public partial class AcceptorRejection : ResponseBase
    {
        public AcceptorRejection()
        {
            this.Data = new AcceptorRejectionData();
            this.Data.Header.MessageFunction = MessageFunctionCode.AcceptorRejection;
        }

        /// <summary>
        /// Root element
        /// </summary>
        [XmlElement("AccptrRjctn")]
        public AcceptorRejectionData Data { get; set; }

        [XmlRoot(ElementName = "AccptrRjctn")]
        public partial class AcceptorRejectionData
        {
            public AcceptorRejectionData()
            {
                this.Header = new Header();
                this.Reject = new Reject();
            }

            /// <summary>
            /// Rejection message management information.
            /// </summary>
            [XmlElement("Hdr")]
            public Header Header { get; set; }

            /// <summary>
            /// Information related to the reject.
            /// </summary>
            [XmlElement("Rjct")]
            public Reject Reject { get; set; }
        }

        public class Reject
        {
            /// <summary>
            /// Information related to the reject.
            /// </summary>
            [XmlElement("RjctRsn")]
            public RejectReasonCode RejectReason { get; set; }

            /// <summary>
            /// Additional information related to the reject of the exchange.
            /// </summary>
            [XmlElement("AddtlInf")]
            public string AdditionalInformation { get; set; }

            /// <summary>
            /// Original request that caused the recipient party to reject it.
            /// </summary>
            [XmlElement("MsgInErr")]
            public string MessageInError { get; set; }
        }
    }
}