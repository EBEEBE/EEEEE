var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var configuration = (IConfiguration)app.Service(typeof(IConfiguration));
app.MapGet("/", () => $"Hello world! Value: {configuration.GetSection("test").Value}");
app.Run();