using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi
{
    public enum ContextAttendanceCode
    {
        /// <summary>
        /// Attended payment, with an attendant.
        /// </summary>
        [XmlEnum("ATTD")]
        Attended,

        /// <summary>
        /// Semi-attended, including self checkout. An attendant supervises several payment, and could be called to help the cardholder.
        /// </summary>
        [XmlEnum("SATT")]
        SemiAttended,

        /// <summary>
        /// Unattended payment, no attendant present.
        /// </summary>
        [XmlEnum("UATT")]
        Unattended,
    }
}