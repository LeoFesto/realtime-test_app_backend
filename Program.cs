
using realtime_on_production_test;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddMvc();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials()
            .SetIsOriginAllowed(origin =>
            {
                // Разрешить все порты на localhost
                if (origin.StartsWith("http://localhost"))
                {
                    return true;
                }
                return false;
            });

    });
});

var app = builder.Build();


app.UseCors();
app.MapControllers();
app.MapHub<ChatHub>("/connection");



app.Run();
