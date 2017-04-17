using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi
{
    public enum AlgorithmCode
    {
        /// <summary>
        /// AES (Advanced Encryption Standard)
        /// CBC (Chaining Block Cypher) encryption
        /// with a 128 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).
        /// </summary>
        [XmlEnum("EA2C")]
        AES128CBC,

        /// <summary>
        /// Triple DES (Data Encryption Standard)
        /// CBC (Chaining Block Cypher) encryption
        /// with double length key (112 Bit) as defined in FIPS PUB 46-3 - (ASN.1 ObjectIdentifier: des-ede3-cbc).
        /// </summary>
        [XmlEnum("E3DC")]
        DES112CBC,

        /// <summary>
        /// DUKPT (Derived Unique Key Per Transaction) algorithm, as specified in ANSI
        /// X9.24-2004, Annex A, and ISO/DIS 13492-2006. - (ASN.1 Object Identifier:id-dukpt-wrap).
        /// </summary>
        [XmlEnum("DKPT")]
        DUKPT,

        /// <summary>
        /// DUKPT (Derived Unique Key Per Transaction) algorithm, as specified in ANSI X9.24-2009 Annex A.
        /// </summary>
        [XmlEnum("DKP9")]
        DUKPT2009,

        /// <summary>
        /// UKPT (Unique Key Per Transaction) or Master Session Key key encryption -(ASN.1 Object Identifier: id-ukpt-wrap).
        /// </summary>
        [XmlEnum("UKPT")]
        UKPT,

        /// <summary>
        /// UKPT (Unique Key Per Transaction) or
        /// Master Session Key key encryption, using Advanced Encryption Standard with
        /// a 128 bits cryptographic key, approved by the Federal Information Processing
        /// Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard)
        /// </summary>
        [XmlEnum("UKA1")]
        UKPTwithAES128,
    }
}