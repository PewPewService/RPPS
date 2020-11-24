using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace SOA
{
    public class XmlSerialize : ISerialize
    {
        public string Serialize<T>(T obj)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var sw = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sw))
                {
                    serializer.Serialize(writer, obj);
                    return sw.ToString();
                }
            }
        }

        public T Deserialize<T>(string str)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var sr = new StringReader(str))
            {
                return (T)serializer.Deserialize(sr);
            }
        }
    }
}
