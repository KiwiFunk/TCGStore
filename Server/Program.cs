var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// CORS configuration
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins(
                "https://localhost:7214",   // Client HTTPS port
                "http://localhost:5128",    // Client HTTP port (fallback)
                "https://localhost:7237",   // Server HTTPS port
                "http://localhost:5271"     // Server HTTP port (fallback)
              )
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseCors(); // Enable CORS

app.MapControllers();

// Start the server
app.Run();
Console.WriteLine("Server is running...");