using ProtoBuf.Grpc.Server;
using TestGrpc.Contract;
using TestGrpcReflection.Grpc;

namespace TestGrpcReflection;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddCodeFirstGrpc();
        // services.TryAddSingleton(BinderConfiguration.Create(binder: new ServiceBinderWithServiceResolutionFromServiceCollection(services)));
        // services.AddCodeFirstGrpcReflection();
    }

    public void Configure(
        IApplicationBuilder app,
        IWebHostEnvironment env)
    {
        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapGrpcService<TestService>();
            // endpoints.MapCodeFirstGrpcReflectionService();
        });
    }
}