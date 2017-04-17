using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi
{
    /// <summary>
    /// Reason of transmission of a rejection message in response to a request or an advice.
    /// </summary>
    public enum RejectReasonCode
    {
        /// <summary>
        /// Not possible to process the message, for
        /// instance the security module is unavailable, the hardware is unavailable, or there
        /// is a problem of resource.
        /// </summary>
        [XmlEnum("UNPR")]
        UnableToProcess,

        /// <summary>
        /// Invalid envelope of the message.
        /// </summary>
        [XmlEnum("IMSG")]
        InvalidMessage,

        /// <summary>
        /// Invalid message: At least one of the data
        /// element or data structure is not present ,
        /// the format, or the content of one data element or one data structure is not correct.
        /// </summary>
        [XmlEnum("PARS")]
        ParsingError,

        /// <summary>
        /// Security error (for example an invalid key
        /// or an incorrect MAC value)
        /// </summary>
        [XmlEnum("SECU")]
        Security,

        /// <summary>
        /// Invalid identification data for the sender.
        /// </summary>
        [XmlEnum("INTP")]
        InitiatingParty,

        /// <summary>
        /// Invalid identification data for the the receiver.
        /// </summary>
        [XmlEnum("RCPP")]
        RecipientParty,

        /// <summary>
        /// Duplicate message, the identification of
        /// the exchange is the same than a previous message.
        /// </summary>
        [XmlEnum("DPMG")]
        DuplicateMessage,

        /// <summary>
        /// Version of the protocol couldn't be supported by the recipient.
        /// </summary>
        [XmlEnum("VERS")]
        ProtocolVersion,

        /// <summary>
        /// Type of message the recipient receives is unknow or unsupported.
        /// </summary>
        [XmlEnum("MSGT")]
        MessageType,
    }
}