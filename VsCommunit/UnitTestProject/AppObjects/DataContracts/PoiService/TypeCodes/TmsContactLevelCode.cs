using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi.TypeCodes
{
    public enum TmsContactLevelCode
    {
        [XmlEnum("CRIT")]
        Critical,

        [XmlEnum("ASAP")]
        AsSoonPossible,

        [XmlEnum("DTIM")]
        DateTime,
    }
}