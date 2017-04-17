using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi
{
    public enum TransactionChannelCode
    {
        /// <summary>
        /// Mail order.
        /// </summary>
        [XmlEnum("MAIL")]
        MailOrder,

        /// <summary>
        /// Telephone order.
        /// </summary>
        [XmlEnum("TLPH")]
        TelephoneOrder,

        /// <summary>
        /// Electronic commerce
        /// </summary>
        [XmlEnum("ECOM")]
        ElectronicCommerce,

        /// <summary>
        /// Payment on television.
        /// </summary>
        [XmlEnum("TVPY")]
        TelevisionPayment,
    }
}