using Microsoft.AspNetCore;

namespace TestGrpcReflection;

class Program
{
    static void Main(string[] args)
    {
        // var builder = WebApplication.CreateBuilder(args);
        // var app = builder.Build();
        //
        // app.MapGet("/", () => "Hello World!");
        //
        // app.Run();
        
        CreateHostBuilder(args).Build().Run();
        
    }

    public static IWebHostBuilder CreateHostBuilder(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>();
}