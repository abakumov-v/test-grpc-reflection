using System.Runtime.Serialization;

namespace TestGrpc.Contract;

[DataContract]
public class SayHelloRequest
{
    [DataMember(Order = 1)] public string Message { get; set; }
}