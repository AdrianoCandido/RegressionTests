using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi
{
    public enum PoiCardDataReadingCode
    {
        /// <summary>
        /// Tag reading capabilities (RFID, etc.)
        /// </summary>
        [XmlEnum("TAGC")]
        Tag,

        /// <summary>
        /// Keyboard entry or OCR reading of embossing or printed data, either at time of
        /// transaction or after the event.
        /// </summary>
        [XmlEnum("PHYS")]
        Physical,

        /// <summary>
        /// Bar code
        /// </summary>
        [XmlEnum("BRCD")]
        BarCode,

        /// <summary>
        /// Magnetic stripe
        /// </summary>
        [XmlEnum("MGST")]
        MagneticStripe,

        /// <summary>
        /// ICC (Integrated Circuit Card) with contact containing software applications conform to ISO 7816
        /// </summary>
        [XmlEnum("CICC")]
        ICC,

        /// <summary>
        /// Account data on file.
        /// </summary>
        [XmlEnum("DFLE")]
        AccountData,

        /// <summary>
        /// Contactless proximity reader
        /// </summary>
        [XmlEnum("CTLS")]
        ProximityReader,

        /// <summary>
        /// Contactless proximity reader, with application conform to the standard EMV
        /// (standard initiated by Europay, Mastercard and Visa).
        /// </summary>
        [XmlEnum("ECTL")]
        EMVProximityReader,
    }
}