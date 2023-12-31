using Demo.CustomerAPI.Context;
using Demo.CustomerAPI.Context.Repositories;
using Demo.CustomerAPI.Model;
using Demo.CustomerAPI.Services;
using Demo.CustomerAPI.Services.Mapping;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(MapProfile));
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IAuthService, AuthService>();

var connectionString = builder.Configuration.GetConnectionString("PostgreSql");
builder.Services.AddEntityFrameworkNpgsql().AddDbContext<CustomerDbContext>(opt =>
        opt.UseNpgsql(connectionString));
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<CustomerDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
