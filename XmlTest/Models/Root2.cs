using System.Runtime.Serialization;

namespace XmlTest.Models
{
    [DataContract(Namespace = "")]
    public class Root2 : Message
    {
        [DataMember]
        public Sub1 Sub1 { get; set; }

        [DataMember]
        public Sub2 Sub2 { get; set; }
    }
}
