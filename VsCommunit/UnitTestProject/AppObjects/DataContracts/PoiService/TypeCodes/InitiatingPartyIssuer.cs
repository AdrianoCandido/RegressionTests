using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi
{
    public enum InitiatingPartyIssuer
    {
        /// <sumary>
        /// Merchant providing goods and service in the card payment transaction.
        /// </sumary>
        [XmlEnum("MERC")]
        Merchant,

        /// <sumary>
        /// Card acceptor, party accepting the card and presenting transaction data to the acquirer.
        /// </sumary>
        [XmlEnum("ACCP")]
        Acceptor,

        /// <sumary>
        /// Party acting on behalf of other parties to process or forward data to other parties.
        /// </sumary>
        [XmlEnum("ITAG")]
        IntermediaryAgent,

        /// <sumary>
        ///Bank of the Merchant providing goods and services
        /// </sumary>
        [XmlEnum("ACQR")]
        Acquirer,

        /// <sumary>
        /// Party that issues cards.
        /// </sumary>
        [XmlEnum("CISS")]
        CardIssuer,

        /// <sumary>
        /// Tax authority.
        /// </sumary>
        [XmlEnum("TAXH")]
        TaxAuthority,
    }
}