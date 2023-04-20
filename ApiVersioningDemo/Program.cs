using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddApiVersioning(e =>
{
    e.AssumeDefaultVersionWhenUnspecified = true;
    e.DefaultApiVersion = new ApiVersion(2, 0);
    e.ReportApiVersions = true;
    e.ApiVersionReader = ApiVersionReader.Combine(
        new QueryStringApiVersionReader("api-vr"),
        new HeaderApiVersionReader("x-version"),
        new MediaTypeApiVersionReader("ver")
        );
});
builder.Services.AddVersionedApiExplorer(e =>
{
    e.GroupNameFormat = "'v'VVV";
    e.SubstituteApiVersionInUrl = true;
});
var app = builder.Build();

app.UseRouting(); 
app.UseEndpoints(e =>
{
    e.MapControllers();
});

app.Run();