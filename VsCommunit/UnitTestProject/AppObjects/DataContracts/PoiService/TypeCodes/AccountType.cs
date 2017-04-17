using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi
{
    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// </summary>
    public enum AccountType
    {
        /// <summary>
        /// Default account.
        /// </summary>
        [XmlEnum("DFLT")]
        Default = 0,

        /// <summary>
        /// Checking account.
        /// </summary>
        [XmlEnum("CHCK")]
        Checking = 1,

        /// <summary>
        /// Credit card account.
        /// </summary>
        [XmlEnum("CRDT")]
        CreditCard = 2,

        /// <summary>
        /// Savings account.
        /// </summary>
        [XmlEnum("SVNG")]
        Savings,

        /// <summary>
        /// Universal account.
        /// </summary>
        [XmlEnum("UVRL")]
        Universal,

        /// <summary>
        /// Investment account.
        /// </summary>
        [XmlEnum("INVS")]
        Investment,

        /// <summary>
        /// Electronic purse card account.
        /// </summary>
        [XmlEnum("EPRS")]
        EpurseCard,
    }
}