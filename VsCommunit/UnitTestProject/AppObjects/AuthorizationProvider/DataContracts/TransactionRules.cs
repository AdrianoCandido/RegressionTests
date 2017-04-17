using System.Runtime.Serialization;

namespace Dlp.Buy4.AuthorizationProvider.Operations
{
    /// <summary>
    /// Rules that a transaction uses.
    /// </summary>
    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/Dlp.Buy4.AuthorizationProvider.Core.Operations")]
    public enum TransactionRules
    {
        /// <summary>
        /// Unspecified rules.
        /// </summary>
        [EnumMember]
        Unspecified,

        /// <summary>
        /// Rules for magnetic stripe transaction.
        /// </summary>
        [EnumMember]
        MagStripe,

        /// <summary>
        /// Rules for integrated circuit card (ICC) transaction.
        /// </summary>
        [EnumMember]
        Icc
    }
}