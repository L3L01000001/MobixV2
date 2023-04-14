using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Mobix.Data;
using Microsoft.AspNetCore.Identity;
using Mobix.EntityModels;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MobixDbContext>(options =>
options.UseSqlServer(
                   builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<Korisnik, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<MobixDbContext>()
                .AddDefaultTokenProviders();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options =>
    {
        options.SlidingExpiration = true;
        options.ExpireTimeSpan = new TimeSpan(0, 1, 0);
    });

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
        {
            builder.WithOrigins("https://localhost:44351", "http://localhost:4200")
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

app.UseCors(builder =>
{
    builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();
});

app.UseHttpsRedirection();
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
