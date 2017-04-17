using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi.TypeCodes
{
    public enum UserInterfaceCode
    {
        /// <summary>
        /// Cardholder display or interface.
        /// </summary>
        [XmlEnum("CDSP")]
        CardholderDisplay,

        /// <summary>
        /// Cardholder receipt.
        /// </summary>
        [XmlEnum("CRCP")]
        CardholderReceipt,

        /// <summary>
        /// Merchant display or interface.
        /// </summary>
        [XmlEnum("MDSP")]
        MerchantDisplay,

        /// <summary>
        /// Merchant receipt.
        /// </summary>
        [XmlEnum("MRCP")]
        MerchantReceipt,
    }
}