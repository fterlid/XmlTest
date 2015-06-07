using System.Runtime.Serialization;

namespace XmlTest.Models
{
    [DataContract(Namespace = "")]
    public class Sub2
    {
        [DataMember]
        public int IntSub2 { get; set; }

        [DataMember]
        public long LongSub2 { get; set; }
    }
}
