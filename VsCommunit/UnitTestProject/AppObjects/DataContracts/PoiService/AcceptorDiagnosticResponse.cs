using Buy4.Services.Sdk.Models.Poi.TypeCodes;
using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi
{
    [XmlRoot(ElementName = "Document", Namespace = "urn:AcceptorDiagnosticResponseV02.1", IsNullable = false)]
    public class AcceptorDiagnosticResponse : ResponseBase
    {
        public AcceptorDiagnosticResponse()
        {
            this.Data = new AcceptorDiagnosticResponseData();
        }

        [XmlElement("AccptrDgnstcRspn")]
        public AcceptorDiagnosticResponseData Data { get; set; }

        public class AcceptorDiagnosticResponseData
        {
            public AcceptorDiagnosticResponseData()
            {
                this.Header = new Header();
                this.DiagnosticResponse = new DiagnosticResponse();
                this.SecurityTrailer = new SecurityTrailer();
                this.Header.MessageFunction = MessageFunctionCode.CancellationAdviceResponse;
            }

            [XmlElement("Hdr")]
            public Header Header { get; set; }

            [XmlElement("DgnstcRspn")]
            public DiagnosticResponse DiagnosticResponse { get; set; }

            [XmlElement("SctyTrlr")]
            public SecurityTrailer SecurityTrailer { get; set; }
        }

        public class DiagnosticResponse
        {
            public DiagnosticResponse()
            {
                this.Environment = new AcceptorDiagnosticRequest.Environment();
            }

            [XmlElement("Envt")]
            public AcceptorDiagnosticRequest.Environment Environment { get; set; }

            [XmlElement("TMSTrggr")]
            public TmsTrigger TmsTrigger { get; set; }
        }

        public class TmsTrigger
        {
            [XmlElement("TMSCtctLvl")]
            public TmsContactLevelCode TmsContactLevel { get; set; }

            [XmlElement("TMSId")]
            public string TmsIdentification { get; set; }

            [XmlElement("TMSCtctDtTm")]
            public string TmsContactDateTime { get; set; }
        }
    }
}