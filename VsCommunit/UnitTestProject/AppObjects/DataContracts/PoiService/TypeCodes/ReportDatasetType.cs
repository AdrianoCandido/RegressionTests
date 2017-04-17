using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi
{
    /// <summary>
    /// parametros de pesquisa
    /// </summary>
    public enum ReportDatasetType
    {
        /// <summary>
        /// Define o parametro de pesquida pelo id do  adquirente
        /// </summary>
        [XmlEnum("RTVF")]
        RecipientTransactionVerification,

        /// <summary>
        /// Define o parametro de pesquisa pelo id do initiator/gatway/tefhouse
        /// </summary>
        [XmlEnum("ITVF")]
        InitiatorTransactionVerification,

        /// <summary>
        /// define o parametro de pesquisa um renge de datas
        /// </summary>
        [XmlEnum("RDVF")]
        RangeDateTime,
    }
}