using System.Runtime.Serialization;

namespace Dlp.Buy4.AuthorizationProvider.Operations
{
    /// <summary>
    /// Types of installments.
    /// </summary>
    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/Dlp.Buy4.AuthorizationProvider.Core.Operations")]
    public enum InstallmentType
    {
        /// <summary>
        /// No installments.
        /// </summary>
        [EnumMember]
        None = 0,

        /// <summary>
        /// Acquirer manages the installments.
        /// </summary>
        [EnumMember]
        Merchant = 1,

        /// <summary>
        /// Issuer manages the installments.
        /// </summary>
        [EnumMember]
        Issuer = 2
    }
}