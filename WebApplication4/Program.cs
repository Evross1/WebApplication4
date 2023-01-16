var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

Services.AddDbContext<LinkDbcontext>(options =>
    {
        optioons.UseSqlite("Filename=C:\\ESS\\Link.db");
    });

app.UseAuthorization();

app.MapControllers();

app.Run();
