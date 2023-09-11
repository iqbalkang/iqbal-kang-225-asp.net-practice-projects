using ConfigurationExample;
using System.Drawing;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.Configure<WeatherAPIOptions>(
    builder.Configuration.GetSection("weatherAPI")
    );

var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints => 
{
    endpoints.Map("/config", async context =>
    {
        //string value = app.Configuration["Key1"];
        //string value = app.Configuration.GetValue<string>("Key1");

        int value = app.Configuration.GetValue<int>("Key1", 10);
        string stringValue = value.ToString();

        await context.Response.WriteAsync(stringValue);
    });

});

app.MapControllers();


app.Run();
