using TestGrpc.Contract;

namespace TestGrpcReflection.Grpc;

public class TestService : ITestService
{
    public async Task<SayHelloResponse> SayHello(SayHelloRequest request)
    {
        var message = string.IsNullOrWhiteSpace(request.Message)
            ? "world"
            : request.Message;

        return new SayHelloResponse()
        {
            Message = $"Hello, {message}"
        };
    }
}