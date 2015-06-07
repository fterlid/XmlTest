using System.Runtime.Serialization;

namespace XmlTest.Models
{
    [DataContract(Namespace = "")]
    public class Root : Message
    {
        [DataMember(Order = 0, Name = "stringprop1")]
        public string StringProp1 { get; set; }

        [DataMember(Order = 1, Name = "stringprop2")]
        public string StringProp2 { get; set; }

        [DataMember(Order = 2, Name = "stringprop3")]
        public string StringProp3 { get; set; }

        [DataMember(Order = 3, Name = "intprop")]
        public int IntProp1 { get; set; }

        [DataMember(Order = 4, Name = "sub1element")]
        public Sub1 Sub1Element { get; set; }
    }
}
