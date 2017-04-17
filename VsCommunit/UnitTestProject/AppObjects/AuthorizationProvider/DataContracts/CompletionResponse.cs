using System.Runtime.Serialization;

namespace Dlp.Buy4.AuthorizationProvider.Core.Operations
{
    /// <summary>
    /// Contains response information for a completion request.
    /// </summary>
    [DataContract]
    public class CompletionResponse : BaseResponse
    {
        /// <summary>
        /// Transaction identification returned by the acquirer for the request.
        /// </summary>
        [DataMember]
        public string AquirerTransactionKey { get; set; }
    }
}