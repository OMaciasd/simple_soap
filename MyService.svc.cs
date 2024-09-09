using System.ServiceModel;

namespace SimpleSOAPService
{
    [ServiceContract]
    public interface IMyService
    {
        [OperationContract]
        string HelloWorld(string name);
    }

    public class MyService : IMyService
    {
        public string HelloWorld(string name)
        {
            return $""Hello, {name}!"";
        }
    }
}
