using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi
{
    public enum AuthenticationMethodCode
    {
        /// <summary>
        /// Authentication bypassed by the merchant.
        /// </summary>
        [XmlEnum("BYPS")]
        Bypass,

        /// <summary>
        /// Manual verification, for example passport or drivers license.
        /// </summary>
        [XmlEnum("MANU")]
        ManualVerification,

        /// <summary>
        /// Merchant-related authentication.
        /// </summary>
        [XmlEnum("MERC")]
        MerchantAuthentication,

        /// <summary>
        /// Off-line PIN authentication (Personal Identification Number).
        /// </summary>
        [XmlEnum("FPIN")]
        OfflinePIN,

        /// <summary>
        /// On-line PIN authentication (Personal Identification Number).
        /// </summary>
        [XmlEnum("NPIN")]
        OnLinePIN,

        /// <summary>
        /// Handwritten paper signature.
        /// </summary>
        [XmlEnum("PPSG")]
        PaperSignature,

        /// <summary>
        /// Authentication by a password.
        /// </summary>
        [XmlEnum("PSWD")]
        Password,

        /// <summary>
        /// Secure electronic transaction with cardholder X.509 certificate.
        /// </summary>
        [XmlEnum("SCRT")]
        SecureCertificate,

        /// <summary>
        /// Channel-encrypted transaction.
        /// </summary>
        [XmlEnum("SCNL")]
        SecuredChannel,

        /// <summary>
        /// Secure electronic transaction without cardholder certificate.
        /// </summary>
        [XmlEnum("SNCT")]
        SecureNoCertificate,

        /// <summary>
        /// Electronic signature capture (handwritten signature).
        /// </summary>
        [XmlEnum("CPSG")]
        SignatureCapture,

        /// <summary>
        /// Authentication method is performed unknown.
        /// </summary>
        [XmlEnum("UKNW")]
        UnknownMethod,
    }
}