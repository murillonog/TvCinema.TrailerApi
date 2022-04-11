using TvCinema.TrailerApi.Service.CrossCutting.IoC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.ConfigureDataBase(builder.Configuration);
builder.Services.ConfigureMapper();
builder.Services.ConfigureServices();
builder.Services.ConfigureRepository();

builder.Services.AddSwaggerGen();
builder.Services.ConfigureSwagger();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
