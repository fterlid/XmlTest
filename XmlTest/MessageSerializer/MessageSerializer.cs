using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using XmlTest.Models;

namespace XmlTest.MessageSerializer
{
    public class MessageSerializer
    {
        public string SerializeMessage(Message message)
        {
            string serializedData;
            
            var serializer = new DataContractSerializer(typeof(Message));
            using (var stringWriter = new StringWriter())
            {
                using (var xmlTextWriter = new MessageXmlTextWriter(stringWriter))
                {
                    xmlTextWriter.Formatting = Formatting.Indented;

                    serializer.WriteStartObject(xmlTextWriter, message);
                    //xmlTextWriter.WriteAttributeString("xmlns", "xyz", null, "http://xyz.no");

                    serializer.WriteObjectContent(xmlTextWriter, message);

                    serializer.WriteEndObject(xmlTextWriter);
                }
                var buffer = stringWriter.GetStringBuilder();
                serializedData = buffer.ToString();
            }

            return serializedData;
        }
    }
}
