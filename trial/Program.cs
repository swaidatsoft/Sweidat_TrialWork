using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.TeamFoundation.Build.WebApi;
using Repository.EF;
using Repository.EF.Repository;
using TrialRepository.Core.Interfaces;
using TrialRepository.Core.Repository;



var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAutoMapper(typeof(Program));
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDBContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddControllers().AddNewtonsoftJson(options =>
{
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
});

//builder.Services.AddTransient(typeof(IBaseRepository<>),typeof(CompanyRepository<>));
//builder.Services.AddTransient(typeof(IBaseRepository<>), typeof(UsersRepository<>));


builder.Services.AddCors(option =>
{
    option.AddDefaultPolicy(policy => { policy.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod(); });
});





builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();

app.UseHttpsRedirection();


app.MapControllers();

app.UseAuthorization();
app.MapControllers();

app.Run();
