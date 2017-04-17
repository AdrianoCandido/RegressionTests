using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi
{
    /// <summary>
    /// Identification of the type of amount.
    /// </summary>
    public enum ContentType
    {
        /// <summary>
        /// Generic, non cryptographic, or unqualified data content - (ASN.1 Object Identifier: id-data).
        /// </summary>
        [XmlEnum("DATA")]
        PlainData,

        /// <summary>
        /// Digital signature - (ASN.1 Object Identifier: id-signedData).
        /// </summary>
        [XmlEnum("SIGN")]
        SignedData,

        /// <summary>
        /// Encrypted data, with encryption key -(ASN.1 Object Identifier: id-envelopedData).
        /// </summary>
        [XmlEnum("EVLP")]
        EnvelopedData,

        /// <summary>
        /// Message digest - (ASN.1 Object Identifier: id-digestedData).
        /// </summary>
        [XmlEnum("DGST")]
        DigestedData,

        /// <summary>
        /// Encrypted data - (ASN.1 Object Identifier: id-encryptedData).
        /// </summary>
        [XmlEnum("ECRP")]
        EncryptedData,

        /// <summary>
        /// MAC (Message Authentication Code),with encryption key - (ASN.1 ObjectIdentifier: id-ct-authData).
        /// </summary>
        [XmlEnum("AUTH")]
        AuthenticatedData,
    }
}