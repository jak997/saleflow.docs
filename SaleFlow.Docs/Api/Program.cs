using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using MongoDB.EntityFrameworkCore.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration.GetSection("Configuration").Get<BLL.Services.Configuration>();

if (config == null)
{
    throw new Exception("Missing 'Configuration' section");
}

builder.Services.AddSingleton(config);
builder.Services.DoBLLClassesInjection(config.DataBase.MockDB);
builder.Services.AddControllers();
builder.Services.AddOpenApi();

#region Jwt Authorization 

builder.Services.AddAuthentication(options => {
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options => {
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = config.Jwt.Issuer,
        ValidAudience = config.Jwt.Audience,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config.Jwt.SecretKey!))
    };
});
builder.Services.AddAuthorization();

#endregion

#region DB Connection

if (string.IsNullOrEmpty(config?.DataBase?.ConnectionString))
{
    throw new InvalidOperationException("Empty connection string.");
}

builder.Services.AddDbContext<DAL.Context>(options =>
{
    options.UseMongoDB(config.DataBase.ConnectionString);
});

#endregion

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.UseAuthorization(); 

app.MapControllers();
app.Run();
