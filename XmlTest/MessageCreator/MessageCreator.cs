using XmlTest.Models;

namespace XmlTest.MessageCreator
{
    public class MessageCreator
    {
        public Message Construct(IMessageBuilder builder)
        {
            builder.BuildSub1();
            builder.BuildSub2();

            return builder.GetMessage();
        }
    }
}
