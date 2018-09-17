using System.ServiceModel;

namespace WcfSample1.Common
{
    [ServiceContract]
    public interface IGreet
    {
        [OperationContract]
        void Hello(Person person);
    }
}