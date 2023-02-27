using System.ServiceModel;

namespace TestGrpc.Contract;

[ServiceContract(Name = "TestService")]
public interface ITestService
{
    [OperationContract]
    Task<SayHelloResponse> SayHello(SayHelloRequest request);
}