using Microsoft.EntityFrameworkCore;
using ProsysBack.Abstractions.Repositories;
using ProsysBack.Concretes.Repositories;
using ProsysBack.DAL;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

var connectingString = builder.Configuration.GetConnectionString("DefaultConnection");

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<ILessonRepository, LessonRepository>();
builder.Services.AddScoped<IExamRepository, ExamRepository>();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
}); ;

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectingString));

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                      });
});

var app = builder.Build();

app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
