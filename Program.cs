using WorldModel;

var builder = WebApplication.CreateBuilder(args);

<<<<<<< HEAD:Program.cs
// Add services to the container

=======
// Add services to the container.
>>>>>>> 9ae84d5 (add countries controller):Comp584Server/Program.cs
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
<<<<<<< HEAD:Program.cs

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
=======
>>>>>>> 9ae84d5 (add countries controller):Comp584Server/Program.cs
builder.Services.AddOpenApi();
builder.Services.AddDbContext<WeatherContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
    
}
app.UseCors(options => options.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.UseAuthorization();

app.MapControllers();

app.Run();
