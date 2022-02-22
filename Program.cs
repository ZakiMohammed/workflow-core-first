using Microsoft.Extensions.DependencyInjection;
using WorkflowCore.Interface;

IServiceProvider serviceProvider = ConfigureServices();

//start the workflow host
var host = serviceProvider.GetService<IWorkflowHost>();
if (host != null)
{
    host.RegisterWorkflow<HelloWorldWorkflow>();
    host.Start();

    host.StartWorkflow("HelloWorld");

    Console.ReadLine();
    host.Stop();
} else {
    Console.WriteLine("Host to initialized");
    Console.ReadLine();
}

IServiceProvider ConfigureServices()
{
    //setup dependency injection
    IServiceCollection services = new ServiceCollection();
    services.AddLogging();
    services.AddWorkflow();
    services.AddTransient<GoodbyeWorld>();

    var serviceProvider = services.BuildServiceProvider();

    return serviceProvider;
}