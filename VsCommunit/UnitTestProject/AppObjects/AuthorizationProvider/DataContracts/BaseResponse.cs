using System.Runtime.Serialization;

namespace Dlp.Buy4.AuthorizationProvider.Core.Operations
{
    [DataContract]
    public class BaseResponse
    {
        [DataMember]
        public bool Success { get; set; }
    }
}