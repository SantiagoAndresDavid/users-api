using Api;

var builder = WebApplication.CreateBuilder(args);

ConfigurationManager configuration = builder.Configuration;
string connectionString =
    configuration.GetConnectionString("DefaultConnection")!;

builder.Services.AddDbContext<UsersDbContext>(options =>
    options.SetupDatabaseEngine(connectionString)
);


// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddServices();
builder.Services.AddRepositories();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    // Disable HTTPS Redirection in Development
    // Comment or remove this line to disable HTTPS redirection
    // app.UseHttpsRedirection();
}
else
{
    app.UseHttpsRedirection(); // Only use HTTPS redirection in Production
}

//app.UseHttpsRedirection();

app.UseRouting();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();


