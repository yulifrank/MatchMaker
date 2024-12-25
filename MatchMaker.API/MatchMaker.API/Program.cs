using MatchMaker.API.Mapping;
using MatchMaker.Core.Repositories;
using MatchMaker.Core.Services;
using MatchMaker.Data.Repositories;
using MatchMaker.Data;
using MatchMaker.Service.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// הוספת שירותי CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocalhost", policy =>
    {
        policy.WithOrigins("http://localhost:4200")  // מקבל את הבקשות מ-localhost:4200
              .AllowAnyHeader()                     // מאפשר כל כותרת
              .AllowAnyMethod();                    // מאפשר כל שיטה (GET, POST, PUT וכו')
    });
});

// Add services to the container.
builder.Services.AddControllers();

// הזרקת ה-DataContext
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// הזרקת השירותים
builder.Services.AddScoped<IIdeaService, IdeaService>();
builder.Services.AddScoped<IPersonService, PersonService>();

// הזרקת ה-Repositories
builder.Services.AddScoped<IIdeaRepository, IdeaRepository>();
builder.Services.AddScoped<IPersonRepository, PersonRepository>();
builder.Services.AddAutoMapper(typeof(PostModelsMappingProfile));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// הוספת תמיכת CORS
app.UseCors("AllowLocalhost");

app.UseAuthorization();

app.MapControllers();

app.Run();
