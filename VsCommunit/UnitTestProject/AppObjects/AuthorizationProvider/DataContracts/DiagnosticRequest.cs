using System.Runtime.Serialization;

namespace Dlp.Buy4.AuthorizationProvider.Core.Models
{
    [DataContract]
    public class DiagnosticRequest
    {
        public int key { get; set; }
    }
}