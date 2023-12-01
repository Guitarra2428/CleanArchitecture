using CleanArchitecture.Common;
using CleanArchitecture.Percistence;
using CleanArchitecture.WebApi;
using CreanArchitecture.Application;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services 
    .AddWebApiS()
    .AddApplication()   
    .AddCommon()
    .AddPercistence(builder.Configuration);
   
builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
