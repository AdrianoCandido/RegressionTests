using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi
{
    [XmlRoot(ElementName = "Document", Namespace = "urn:AcceptorTransactionStatusReportRequestV02.1", IsNullable = false)]
    public class AcceptorTransactionStatusReportRequest
    {
        [XmlElement("AccptrTxStsRptRq")]
        public AccptrTxStsRptRq AccptrTxStsRptRqData { get; set; }

        public class AccptrTxStsRptRq
        {
            [XmlElement("Hdr")]
            public Header Header { get; set; }

            public TxStsRpt TxStsRpt { get; set; }
        }

        public class TxStsRpt
        {
            [XmlElement("Tx")]
            public Collection<Transaction> Transaction { get; set; }
        }

        public class Transaction
        {
            [XmlElement("TxRpt")]
            public Collection<TxRpt> TxRpt { get; set; }

            [XmlElement("OrgnlTx")]
            public OrgnlTx OrgnlTx { get; set; }
        }

        public class OrgnlTx
        {
            [XmlElement("RcptTxId")]
            public string RcptTxId { get; set; }

            [XmlElement("InitrTxId")]
            public string InitrTxId { get; set; }
        }

        public enum TxRpt
        {
            SUMM,
            OPRS
        }
    }
}