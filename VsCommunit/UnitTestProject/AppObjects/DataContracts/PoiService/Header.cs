using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi
{
    /// <summary>
    /// Cancellation request message management information
    /// </summary>

    public partial class Header
    {
        public Header()
        {
            this.ProtocolVersion = "2.0";
            this.CreationDateTime = TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time")).ToString("yyyy-MM-ddTHH:mm:ss");
        }

        /// <summary>
        /// Identifies the type of process related to the message.
        /// </summary>

        [XmlElement("MsgFctn")]
        public Nullable<MessageFunctionCode> MessageFunction { get; set; }

        /// <summary>
        /// Version of the acquirer protocol specifications.
        /// </summary>
        [XmlElement("PrtcolVrsn")]
        public string ProtocolVersion { get; set; }

        /// <summary>
        /// Unique identification of an exchange occurrence.
        /// </summary>
        [XmlElement("XchgId")]
        public string ExchangeIdentification { get; set; }

        /// <summary>
        /// Date and time at which the message was created.
        /// </summary>
        [XmlElement("CreDtTm")]
        public string CreationDateTime { get; set; }

        /// <summary>
        /// Unique identification of the partner that has initiated the exchange.
        /// </summary>
        //
        [XmlElement("InitgPty")]
        public GenericIdentification InitiatingParty { get; set; }

        /// <summary>
        /// Unique identification of the partner that is the recipient of the message exchange.
        /// </summary>
        [XmlElement("RcptPty")]
        public GenericIdentification RecipientParty { get; set; }

        /// <summary>
        ///  Identification of partners involved in exchange from the merchant to the issuer,
        ///  with the relative timestamp of their exchanges.
        /// </summary>
        [XmlElement("Tracblt")]
        public List<Traceability> Traceability { get; set; }
    }

    public partial class Traceability
    {
        /// <summary>
        /// Identification of a partner of a message exchange.
        /// </summary>
        [XmlElement("RlayId")]
        public GenericIdentification RelayIdentification { get; set; }

        /// <summary>
        /// Date and time of incoming data exchange for relaying or processing.
        /// </summary>
        [XmlElement("TracDtTmIn")]
        public string TraceDateTimeIn { get; set; }

        /// <summary>
        ///  Date and time of the outgoing exchange for relaying or processing.
        /// </summary>
        [XmlElement("TracDtTmOut")]
        public string TraceDateTimeOut { get; set; }
    }
}