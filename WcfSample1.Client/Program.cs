using System;
using System.ServiceModel;
using WcfSample1.Common;

namespace WcfSample1.Client
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                var channel = ChannelFactory<IGreet>.CreateChannel(
                    new NetNamedPipeBinding(NetNamedPipeSecurityMode.Transport), 
                    new EndpointAddress("net.pipe://localhost/wcfsample1/test/"));

                var person = new Person { Age = 10, Name = "alice" };
                channel.Hello(person);

                Console.WriteLine("press any key to exit...");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Failed.");
            }
        }
    }
}