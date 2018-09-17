using System;
using WcfSample1.Common;

namespace WcfSample1.Host
{
    public class Greet : IGreet
    {
        public void Hello(Person person)
        {
            Console.WriteLine($"Hello, {person.Name}");
        }
    }
}