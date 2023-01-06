using MySignalRExample.Hubs;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();


var app = builder.Build();

app.UseStaticFiles();
app.MapGet("/", () => Results.Redirect("/index.html"));

app.Run();
