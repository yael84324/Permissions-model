using MyProject.Mock;
using MyProject.Repositories.Interfaces;
using tray.first.Interface;
using MyProject.Repositories.Repositories;
//הוא משתגע כשהוא צריך למחוק אחד של קיים
//למה מוסיפים בתחילת קונטרור בתוך הניימספייס את שתי הריבועים
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();
builder.Services.AddScoped<IPermissionRepository, PermissionRepository>();
builder.Services.AddScoped<IClaimRepository, ClaimRepository>();
builder.Services.AddSingleton<IContext, MockContext>();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
