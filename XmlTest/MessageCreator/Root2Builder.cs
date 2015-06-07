using XmlTest.Models;

namespace XmlTest.MessageCreator
{
    public class Root2Builder : IMessageBuilder
    {
        private readonly Root2 _message;
        public Root2Builder()
        {
            _message = new Root2();
        }

        public void BuildSub1()
        {
            _message.Sub1 = new Sub1();
        }

        public void BuildSub2()
        {
            _message.Sub2 = new Sub2();
        }

        public Message GetMessage()
        {
            return _message;
        }
    }
}
