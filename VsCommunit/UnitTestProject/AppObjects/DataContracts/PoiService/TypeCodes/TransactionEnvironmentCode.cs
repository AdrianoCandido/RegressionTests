using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi
{
    public enum TransactionEnvironmentCode
    {
        /// <summary>
        /// Merchant environment.
        /// </summary>
        [XmlEnum("MERC")]
        Merchant,

        /// <summary>
        /// Private environment.
        /// </summary>
        [XmlEnum("PRIV")]
        Private,

        /// <summary>
        /// Public environment.
        /// </summary>
        [XmlEnum("PUBL")]
        Public,
    }
}