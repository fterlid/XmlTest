using System.Runtime.Serialization;

namespace XmlTest.Models
{
    [DataContract(Namespace = "")]
    public class Sub1
    {
        [DataMember(Order = 0, Name = "sub2prop")]
        public Sub2 Sub2Prop { get; set; }

        [DataMember(Order = 1, Name = "stringsub1", EmitDefaultValue = true)]
        public string StringSub1 { get; set; }

        [OnSerializing]
        public void OnSerializing(StreamingContext streamingContext)
        {
            if (string.IsNullOrWhiteSpace(StringSub1))
            {
                StringSub1 = string.Empty;
            }
        }
    }
}
