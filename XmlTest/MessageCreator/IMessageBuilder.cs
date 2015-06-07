using XmlTest.Models;

namespace XmlTest.MessageCreator
{
    public interface IMessageBuilder
    {
        void BuildSub1();
        void BuildSub2();
        Message GetMessage();
    }
}