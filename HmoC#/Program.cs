using AutoMapper;
using Bll;
using Dal;
using Entity;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped(typeof(IFriendBll), typeof(FriendBll));
builder.Services.AddScoped(typeof(IVaccinationBll), typeof(VaccinationBll));
builder.Services.AddScoped(typeof(ISickBll), typeof(SickBll));

builder.Services.AddScoped(typeof(IFriendDal), typeof(FriendDal));
builder.Services.AddScoped(typeof(ISickDal), typeof(SickDal));
builder.Services.AddScoped(typeof(IVaccinationDal), typeof(VaccinationDal));

builder.Services.AddDbContext<DataBaseHmo>();
var mapperConfing = new MapperConfiguration(mc =>
{
    mc.AddProfile(new AutoMapperProfil());
});
IMapper mapper = mapperConfing.CreateMapper();
builder.Services.AddSingleton(mapper);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(x=>x.AllowAnyHeader()
.AllowAnyMethod()
.AllowAnyOrigin());
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
