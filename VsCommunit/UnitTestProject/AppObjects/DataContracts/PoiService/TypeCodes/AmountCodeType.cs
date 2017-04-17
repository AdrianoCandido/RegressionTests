using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi
{
    /// <summary>
    /// Identification of the type of amount.
    /// </summary>
    public enum AmountCodeType
    {
        /// <summary>
        /// Cash-back amount.
        /// </summary>
        [XmlEnum("CSHB")]
        Cashback,

        /// <summary>
        /// Gratuity amount.
        /// </summary>
        [XmlEnum("GRTY")]
        Gratuity,

        /// <summary>
        /// Fees
        /// </summary>
        [XmlEnum("FEES")]
        Fees,

        /// <summary>
        /// Global rebate of the transaction. This
        /// amount is counted as a negative amount.
        /// </summary>
        [XmlEnum("RBTS")]
        Rebates,

        /// <summary>
        /// Value added tax amount.
        /// </summary>
        [XmlEnum("VATX")]
        ValueAddedTax,
    }
}