using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi
{
    [XmlRoot(ElementName = "Document", Namespace = "urn:AcceptorDiagnosticRequestV02.1", IsNullable = false)]
    public class AcceptorDiagnosticRequest
    {
        [XmlElement("AccptrDgnstcReq")]
        public AcceptorDiagnosticRequestData Data { get; set; }

        public class AcceptorDiagnosticRequestData
        {
            [XmlElement("Hdr")]
            public Header Header { get; set; }

            [XmlElement("DgnstcReq")]
            public DiagnosticRequest DiagnosticRequest { get; set; }

            [XmlElement("SctyTrlr")]
            public SecurityTrailer SecurityTrailer { get; set; }
        }

        public class DiagnosticRequest
        {
            [XmlElement("Envt")]
            public Environment Environment { get; set; }
        }

        public class Environment
        {
            [XmlElement("AcqrrParamsVrsn")]
            public string AcquirerParametersVersion { get; set; }

            [XmlElement("MrchntId")]
            public GenericIdentification MerchantIdentification { get; set; }

            [XmlElement("POIId")]
            public GenericIdentification PoiIdentification { get; set; }
        }
    }
}