using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace PoiServiceRegressionTests.AppObjects.Serialization
{
    /// <summary>
    /// Serializer for XML representation.
    /// </summary>
    public class XSerializer
    {
        public static T Deserialize<T>(string data)
        {
            return (T)new XmlSerializer(typeof(T)).Deserialize(new StringReader(data));
        }

        public static string Serialize(object obj)
        {
            return Serialize(obj, XmlQualifiedName.Empty, false, true);
        }

        public static string Serialize(object obj, XmlQualifiedName xmlQualifiedName, bool omitXmlDeclaration, bool Indent)
        {
            if (obj == null)
                return null;

            Type type = obj.GetType();
            string ns = "";

            XmlRootAttribute root = type.GetCustomAttribute<XmlRootAttribute>();
            if (root != null && root.Namespace != null)
            {
                ns = root.Namespace.Replace("urn:", "").Replace(".", "/");
            }

            var _namespace = xmlQualifiedName != null ? new XmlSerializerNamespaces(new[] { xmlQualifiedName }) : new XmlSerializerNamespaces(new[] { new XmlQualifiedName("xsd", string.Format("http://schemas.stone.com/{0}", ns)) });

            var settings = new XmlWriterSettings();

            settings.Indent = Indent;
            settings.OmitXmlDeclaration = omitXmlDeclaration;

            using (MemoryStream stream = new MemoryStream())
            using (XmlWriter writer = new XmlTextWriter(stream, new UTF8Encoding()))
            {
                new XmlSerializer(obj.GetType()).Serialize(writer, obj, _namespace);
                stream.Position = 0;
                return new StreamReader(stream).ReadToEnd();
            }
        }
    }
}