using Grpc.Sample.Endpoint.Courses.Services;
using Grpc.Sample.Infra.Data.Sql.Commands.Common;
using Grpc.Sample.Infra.Data.Sql.Queries.Common;
using M.YZ.Basement.EndPoints.Web;
using M.YZ.Basement.EndPoints.Web.StartupExtensions;
using M.YZ.Basement.Utilities.Configurations;
using Microsoft.EntityFrameworkCore;

var builder = new BasementProgram().Main(args, "appsettings.json", "appsettings.basement.json", "appsettings.serilog.json");

// Additional configuration is required to successfully run gRPC on macOS.
// For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682

// Add services to the container.
builder.Services.AddBasementApiServices(builder.Configuration);

builder.Services.AddDbContext<GRpcSampleCommandDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Grpc_Context"));
});

builder.Services.AddDbContext<GRpcSampleQueryDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Grpc_Context"));
});

var app = builder.Build();

var basementConfigurationOptions = app.Services.GetRequiredService<BasementConfigurationOptions>();

app.UseBasementApiConfigure(basementConfigurationOptions, app.Environment);

// Configure the HTTP request pipeline.

app.MapGrpcService<CourseService>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();