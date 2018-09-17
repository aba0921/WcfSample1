using System;
using System.ServiceModel;
using WcfSample1.Common;

namespace WcfSample1.Host
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ServiceHost serviceHost = default;
            try
            {
                serviceHost = new ServiceHost(typeof(Greet), new Uri("http://localhost:40012/wcfsample1/"));
                serviceHost.AddServiceEndpoint(typeof(IGreet),
                    new BasicHttpBinding(BasicHttpSecurityMode.TransportCredentialOnly), "test");
                serviceHost.Open();

                Console.WriteLine("press any key to exit...");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                serviceHost?.Close();
            }

            Console.WriteLine("service is closed.");
            Console.ReadLine();
        }
    }
}