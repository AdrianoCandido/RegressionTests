using System.Runtime.Serialization;

namespace Dlp.Buy4.AuthorizationProvider.Operations
{
    ///<summary>
    /// Type of account for a transaction.
    ///</summary>
    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/Dlp.Buy4.AuthorizationProvider.Core.Operations")]
    public enum AccountType
    {
        /// <summary>
        /// Unspecified account. Use default.
        /// </summary>
        [EnumMember]
        Default = 0,

        [EnumMember]
        Savings = 10,

        [EnumMember]
        Checking = 20,

        [EnumMember]
        Credit = 30,

        [EnumMember]
        Universal = 40
    }
}