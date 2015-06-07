using System.Runtime.Serialization;

namespace XmlTest.Models
{
    [DataContract(Namespace = "", Name = "message")]
    [KnownType(typeof(Root))]
    [KnownType(typeof(Root2))]
    public class Message
    {
        [DataMember]
        public int MessageNumber { get; set; }
    }
}
