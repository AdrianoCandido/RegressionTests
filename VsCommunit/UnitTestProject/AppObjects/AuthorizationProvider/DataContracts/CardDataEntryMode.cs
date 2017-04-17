using System.Runtime.Serialization;

namespace Dlp.Buy4.AuthorizationProvider.Operations
{
    /// <summary>
    /// The way card data was read from the card.
    /// </summary>
    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/Dlp.Buy4.AuthorizationProvider.Core.Operations")]
    public enum CardDataEntryMode
    {
        /// <summary>
        /// The entry mode is not known.
        /// </summary>
        [EnumMember]
        Unknown = 0,

        /// <summary>
        /// The entry mode is not in this list.
        /// </summary>
        [EnumMember]
        Other = 1,

        /// <summary>
        /// Magnetic stripe was read.
        /// </summary>
        [EnumMember]
        MagStripe = 2,

        /// <summary>
        /// Integrated circuit card (ICC) was read.
        /// </summary>
        [EnumMember]
        Icc = 3,

        /// <summary>
        /// Data was read using contactless technology.
        /// </summary>
        [EnumMember]
        Contactless = 4,

        /// <summary>
        /// Electronic commerce used.
        /// </summary>
        [EnumMember]
        ECommerce = 5,

        /// <summary>
        /// Mail order.
        /// </summary>
        [EnumMember]
        Mail = 6,

        /// <summary>
        /// Phone / Automated response unit order.
        /// </summary>
        [EnumMember]
        Phone = 7,

        /// <summary>
        /// Fallback transaction.
        /// </summary>
        [EnumMember]
        FallBack = 8
    }
}