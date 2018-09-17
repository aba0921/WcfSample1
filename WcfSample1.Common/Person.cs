using System.Runtime.Serialization;

namespace WcfSample1.Common
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public int Age { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}