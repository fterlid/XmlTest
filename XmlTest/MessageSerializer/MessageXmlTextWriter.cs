using System.IO;
using System.Xml;

namespace XmlTest.MessageSerializer
{
    public class MessageXmlTextWriter : XmlTextWriter
    {
        public MessageXmlTextWriter(TextWriter w) : base(w)
        {
        }

        public override void WriteEndElement()
        {
            WriteFullEndElement();
        }
    }
}
