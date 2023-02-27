// See https://aka.ms/new-console-template for more information

using Grpc.Net.Client;
using ProtoBuf.Grpc.Client;
using TestGrpc.Contract;

GrpcClientFactory.AllowUnencryptedHttp2 = true;

using var grpcChannel = GrpcChannel.ForAddress("http://localhost:5006");
await Task.Delay(1000);
var service = grpcChannel.CreateGrpcService<ITestService>();

var request = new SayHelloRequest()
{
    Message = "John Doe"
};
var result = await service.SayHello(request);
Console.WriteLine(result.Message);
