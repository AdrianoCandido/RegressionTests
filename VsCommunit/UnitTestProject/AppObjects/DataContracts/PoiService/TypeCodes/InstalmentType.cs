using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi
{
    public enum InstalmentType
    {
        [XmlEnum("NONE")]
        None = 0,

        [XmlEnum("MCHT")]
        Merchant = 1,

        [XmlEnum("ISSR")]
        Issuer = 2
    }
}