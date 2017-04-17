using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi
{
    public enum AdditionalService
    {
        /// <summary>
        /// Aggregation   Aggregation of low payments.
        /// </summary>
        AGGR,

        /// <summary>
        /// Dynamic currency conversion (DCC).
        /// </summary>
        DCCV,

        /// <summary>
        /// Card payment with gratuity.
        /// </summary>
        GRTT,

        /// <summary>
        /// Loyalty services.
        /// </summary>
        LOYT,

        /// <summary>
        /// No show after reservation.
        /// </summary>
        NRES,

        /// <summary>
        /// Purchase and corporate data.
        /// </summary>
        PUCO,

        /// <summary>
        /// Recurring payment.
        /// </summary>
        RECP,

        /// <summary>
        /// Solicited available funds.
        /// </summary>
        SOAF,

        /// <summary>
        /// Voice authorisation.
        /// </summary>
        VCAU,

        /// <summary>
        /// Instalment payment transaction performed    by the card issuer.
        /// </summary>
        INSI,

        /// <summary>
        /// Instalment payment transaction performed     by the acceptor or the acquirer.
        /// </summary>
        INSA,

        /// <summary>
        /// Card payment with cash-back.
        /// </summary>
        CSHB,

        /// <summary>
        /// MasterCard Agro Card.
        /// </summary>
        [XmlEnum("AGRO")]
        MasterCardAgroCard,
    }
}