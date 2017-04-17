using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi
{
    /// <summary>
    /// Result of the transaction.
    /// </summary>
    public enum ResponseCode
    {
        /// <summary>
        /// Service is declined.
        /// </summary>
        [XmlEnum("DECL")]
        Declined,

        /// <summary>
        /// Service has been successfuly provided.
        /// </summary>
        [XmlEnum("APPR")]
        Approved,

        /// <summary>
        /// Service has been partialy provided.
        /// </summary>
        [XmlEnum("PART")]
        PartialApproved,

        /// <summary>
        /// Service cannot be provided for technical
        /// reason (eg timeout contacting the Issuer,
        /// security problem).
        /// </summary>
        [XmlEnum("TECH")]
        TechnicalError,
    }
}