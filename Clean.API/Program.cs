using Clean.Core.Repositories;
using Clean.Core.Services;
using Clean.Core;
using Clean.Data.Repositories;
using Clean.Data;
using Clean.Service;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// הוספת שירותים לעבודה עם ה-Architect
builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddScoped<IArchitectService, ArchitectService>();  // הוספתי
builder.Services.AddScoped<IArchitectRepository, ArchitectRepository>();  // הוספתי

// הוספת שירותים אחרים
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();

builder.Services.AddScoped<IMeetingService, MeetingService>();
builder.Services.AddScoped<IMeetingRepository, MeetingRepository>();

// הוספת ה-DbContext
builder.Services.AddDbContext<DataContext>();

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
