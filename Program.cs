using DinerFlow.User;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi()
    .AddScoped<IUserRepository, UserRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapUserEndpoints(); 
app.UseHttpsRedirection();

app.Run();
