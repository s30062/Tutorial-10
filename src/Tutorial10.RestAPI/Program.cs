
using Microsoft.EntityFrameworkCore;
using Tutorial10.RestAPI;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new Exception("No connection string");
builder.Services.AddDbContext<S30062Context>(options => options.UseSqlServer(connectionString));


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();




var app = builder.Build();
app.UseHttpsRedirection();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/api/jobs", (SampleCompanyContext context, CancellationToken token) => {
    try
    {
        return Results.Ok(await context.Jobs.ToListAsync(token));
    }
    catch (Exception ex)
    {
        return Results.Problem(ex.Message);
    }
    
});

app.MapGet("/api/departments", () => {
    
});

app.MapGet("/api/employees", () =>
{
    
});

app.MapGet("/api/employees/{id}", (int id) =>
{
    
});

app.MapPost("/api/employees", () =>
{
    
});

app.MapPut("/api/employees/{id}", (int id) =>
{
    
});

app.MapDelete("/api/employees/{id}", (int id) =>
{
    
});

app.Run();
