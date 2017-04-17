using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi
{
    [XmlRoot(ElementName = "Document", Namespace = "urn:AcceptorTransactionStatusReportResponseV02.2", IsNullable = false)]
    public class AcceptorTransactionStatusReportResponseV2 : ResponseBase
    {
        public AcceptorTransactionStatusReportResponseV2()
        {
            this.TransactionStatusReportResponseData = new AcceptorTransactionStatusReportResponseData();
        }

        [XmlElement("AccptrTxStsRptRspn")]
        public AcceptorTransactionStatusReportResponseData TransactionStatusReportResponseData { get; set; }

        public class AcceptorTransactionStatusReportResponseData
        {
            public AcceptorTransactionStatusReportResponseData()
            {
                this.Header = new Header();
                this.TransactionStatusReportResponse = new TransactionStatusReportResponse();

                this.Header.MessageFunction = MessageFunctionCode.TransactionStatusReportResponse;
            }

            /// <summary>
            /// Authorisation request message management information.
            /// </summary>
            [XmlElement("Hdr")]
            public Header Header { get; set; }

            /// <summary>
            /// Response of the report
            /// </summary>
            [XmlElement("TxStsRpt")]
            public TransactionStatusReportResponse TransactionStatusReportResponse { get; set; }
        }

        public class TransactionStatusReportResponse
        {
            public TransactionStatusReportResponse()
            {
                this.Enviroment = new Enviroment();
                this.DataSet = new DataSet();
            }

            /// <summary>
            /// Enviroment of the response
            /// </summary>
            [XmlElement("Envt")]
            public Enviroment Enviroment { get; set; }

            /// <summary>
            /// Data set of the Transaction
            /// </summary>
            [XmlElement("DataSet")]
            public DataSet DataSet { get; set; }
        }

        public class Enviroment
        {
        }

        public class DataSetId
        {
            /// <summary>
            /// Define o tipo de dataset.
            /// </summary>

            [XmlElement("Tp")]
            public ReportDatasetType DatasetType { get; set; }
        }

        public class DataSet
        {
            public DataSet()
            {
                this.DataSetIdentification = new DataSetId();
                this.Result = new TransactionVerificationResult();
            }

            /// <summary>
            /// Identificação do dataset
            /// </summary>

            [XmlElement("DataSetId")]
            public DataSetId DataSetIdentification { get; set; }

            /// <summary>
            ///search result
            /// </summary>
            [XmlElement("Rslt")]
            public TransactionVerificationResult Result { get; set; }
        }

        public class TransactionVerificationResult
        {
            public TransactionVerificationResult()
            {
                this.Authorizations = new Collection<Authorization>();
            }

            private Collection<Authorization> Authorizations { get; set; }
        }

        public class Authorization
        {
            [XmlElement("Card")]
            public Card Card { get; set; }

            [XmlElement("MrchntId")]
            public GenericIdentification Merchant { get; set; }
        }

        public class Card
        {
            [XmlElement("PAN")]
            public string CardNumber { get; set; }

            [XmlElement("XpryDt")]
            public string ExpirationDate { get; set; }

            [XmlElement("CardBrnd")]
            public string CardBrnd { get; set; }
        }

        public class Transaction
        {
        }

        public class TransactionDetails
        {
        }
    }
}