using System.Xml.Serialization;

namespace Buy4.Services.Sdk.Models.Poi
{
    /// <summary>
    /// Identification of an entity
    /// </summary>
    public partial class GenericIdentification
    {
        /// <summary>
        /// Identification of the entity
        /// Max35Text
        /// </summary>
        [XmlElement("Id")]
        public string Identification { get; set; }

        /// <sumary>
        /// Name of the entity.
        /// </sumary>

        [XmlElement("ShrtNm")]
        public string ShortName { get; set; }
    }
}