using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi
{
    [XmlRoot(ElementName = "Document", Namespace = "urn:AcceptorTransactionStatusReportResponseV02.1", IsNullable = false)]
    public class AcceptorTransactionStatusReportResponse : ResponseBase
    {
        public AcceptorTransactionStatusReportResponse()
        {
            this.Data = new AcceptorTransactionStatusReportResponseData();
        }

        [XmlElement("AccptrTxStsRptRspn")]
        public AcceptorTransactionStatusReportResponseData Data { get; set; }

        public class AcceptorTransactionStatusReportResponseData
        {
            public AcceptorTransactionStatusReportResponseData()
            {
                this.Header = new Header();
                this.TransactionStatusReportResponse = new TransactionStatusReportResponse();
            }

            [XmlElement("Hdr")]
            public Header Header { get; set; }

            [XmlElement("TxStsRptRspn")]
            public TransactionStatusReportResponse TransactionStatusReportResponse { get; set; }
        }

        public enum OperationStatus
        {
            FULL,
            PART,
            NONE
        }

        public class TransactionStatusReportResponse
        {
            public TransactionStatusReportResponse()
            {
                this.Transactions = new Collection<Transaction>();
            }

            [XmlElement("Tx")]
            public Collection<Transaction> Transactions { get; set; }
        }

        public class Transaction
        {
            [XmlElement("Summry")]
            public Summary Summary { get; set; }

            [XmlElement("Oprs")]
            public Operations Operations { get; set; }
        }

        public class Summary
        {
            public Summary()
            {
                this.Instlmt = new Installment();

                this.AddtlSvc = new List<AdditionalService>();
            }

            public string RcptTxId { get; set; }
            public string InitrTxId { get; set; }
            public string AcqrrDtTm { get; set; }
            public string LclDtTm { get; set; }
            public string FrstCaptrDtTm { get; set; }
            public string FrstCxlDtTm { get; set; }
            public string TtlOrgnlAmt { get; set; }
            public string TtlAuthrsdAmt { get; set; }
            public string TtlCaptrdAmt { get; set; }
            public string TtlCancAmt { get; set; }
            public OperationStatus AuthrsdSts { get; set; }
            public OperationStatus CaptrdSts { get; set; }
            public OperationStatus CancSts { get; set; }
            public int Ccy { get; set; }
            public AccountType AcctTp { get; set; }
            public string MrchntShrtNm { get; set; }
            public string MrchntCtgyCd { get; set; }

            [XmlElement("AddtlSvc")]
            public List<AdditionalService> AddtlSvc { get; set; }

            public Installment Instlmt { get; set; }
        }

        public class Installment
        {
            public int TtlNbOfPmts { get; set; }
        }

        public class Operations
        {
            public Operations()
            {
                this.Authorization = new Authorization();
                this.Cancelations = new Collection<Cancelations>();
                this.AuthorizationCapture = new Collection<Captures>();
            }

            [XmlElement("Authstn")]
            public Authorization Authorization { get; set; }

            [XmlElement("AuthstnCaptr")]
            public Collection<Captures> AuthorizationCapture { get; set; }

            [XmlElement("Cxl")]
            public Collection<Cancelations> Cancelations { get; set; }
        }

        public class Authorization
        {
            public string RcptOprId { get; set; }
            public string AcqrrDtTm { get; set; }
            public string LclDtTm { get; set; }
            public string OrgnlAmt { get; set; }
            public string AuthrsdAmt { get; set; }
            public ResponseCode Rspn { get; set; }
            public string RspnRsn { get; set; }
            public string AuthstnCd { get; set; }
        }

        public class Captures
        {
            public string RcptOprId { get; set; }
            public string AcqrrDtTm { get; set; }
            public string LclDtTm { get; set; }
            public string Amt { get; set; }
            public ResponseCode Rspn { get; set; }
            public string RspnRsn { get; set; }
        }

        public class Cancelations
        {
            public string RcptOprId { get; set; }
            public string AcqrrDtTm { get; set; }
            public string LclDtTm { get; set; }
            public string Amt { get; set; }
            public ResponseCode Rspn { get; set; }
            public string RspnRsn { get; set; }
        }
    }
}