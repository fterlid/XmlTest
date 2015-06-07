using System;
using XmlTest.MessageCreator;

namespace XmlTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var messageCreator = new MessageCreator.MessageCreator();
            var rootBuilder = new RootBuilder();
            //var rootBuilder = new Root2Builder();

            var data = messageCreator.Construct(rootBuilder);

            var serializer = new MessageSerializer.MessageSerializer();
            var serializedString = serializer.SerializeMessage(data);

            Console.WriteLine(serializedString);
        }
    }
}
