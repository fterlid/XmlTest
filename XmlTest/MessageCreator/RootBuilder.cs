using XmlTest.Models;

namespace XmlTest.MessageCreator
{
    public class RootBuilder : IMessageBuilder
    {
        private readonly Root _root;

        public RootBuilder()
        {
            _root = new Root();
        }

        public void BuildSub1()
        {
            _root.Sub1Element = new Sub1
            {
                Sub2Prop = new Sub2()
            };
        }

        public void BuildSub2()
        {
        }

        public Message GetMessage()
        {
            _root.IntProp1 = 123;
            _root.StringProp1 = "Hello";
            _root.StringProp2 = "World!";
            //_root.StringProp3 = string.Empty;

            return _root;
        }
    }
}
