using System.Runtime.Serialization;

namespace Dlp.Buy4.AuthorizationProvider.Core.Operations
{
    /// <summary>
    /// Contains response information for a reversal request.
    /// </summary>
    [DataContract]
    public class ReversalResponse : BaseResponse
    {
        /// <summary>
        /// Transaction identification returned by the acquirer for the request.
        /// </summary>
        [DataMember]
        public string AquirerTransactionKey { get; set; }

        [DataMember]
        public string ActionCode { get; set; }

        [DataMember]
        public long? Balance { get; set; }

        [DataMember]
        public string AuthorizationCode { get; set; }

        [DataMember]
        public string ServiceReport { get; set; }
    }
}