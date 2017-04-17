using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi.TypeCodes
{
    /// <summary>
    /// Type of action to be performed by the point of interaction (POI).
    /// </summary>
    public enum ActionTypeCode
    {
        /// <summary>
        /// Server busy, try later.
        /// </summary>
        [XmlEnum("BUSY")]
        Busy,

        /// <summary>
        /// Capture the card.
        /// </summary>
        [XmlEnum("CPTR")]
        CaptureCard,

        /// <summary>
        /// Display a message.
        /// </summary>
        [XmlEnum("DISP")]
        DisplayMessage,

        /// <summary>
        /// Payment application cannot propose to the merchant an override of the payment transaction.
        /// </summary>
        [XmlEnum("NOVR")]
        ForbidOverride,

        /// <summary>
        /// Additional identification required (passport, ID card, etc.).
        /// </summary>
        [XmlEnum("RQID")]
        IdentificationRequired,

        /// <summary>
        /// Last PIN (Personal Identification Number) try.
        /// </summary>
        [XmlEnum("PINL")]
        PINLastTry,

        /// <summary>
        /// PIN (Personal Identification Number) is wrong, retry a PIN verification.
        /// </summary>
        [XmlEnum("PINR")]
        PINRetry,

        /// <summary>
        /// Print a message.
        /// </summary>
        [XmlEnum("PRNT")]
        PrintMessage,

        /// <summary>
        /// Referral has to be performed.
        /// </summary>
        [XmlEnum("RFRL")]
        Referral,

        /// <summary>
        /// Request additional data through a displayed text and request confirmation by an attendant.
        /// </summary>
        [XmlEnum("RQDT")]
        RequestData,
    }
}