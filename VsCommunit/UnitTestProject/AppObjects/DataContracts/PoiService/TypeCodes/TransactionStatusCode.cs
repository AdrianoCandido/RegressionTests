using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi
{
    public enum TransactionStatusCode
    {
        [XmlEnum("CLSD")]
        Closed,

        [XmlEnum("OPEN")]
        Opened,

        [XmlEnum("REVT")]
        Reversed,
    }
}