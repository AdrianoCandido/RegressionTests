using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi
{
    /// <summary>
    /// Trailer of the message containing a MAC
    /// </summary>
    public class SecurityTrailer
    {
        [XmlElement("CnttTp")]
        public ContentType ContentType { get; set; }
    }
}