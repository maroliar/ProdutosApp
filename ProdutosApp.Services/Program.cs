using ProdutosApp.Services.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddSwagger();

var app = builder.Build();

app.UseSwaggerDoc();

app.UseAuthorization();

app.MapControllers();

app.Run();



