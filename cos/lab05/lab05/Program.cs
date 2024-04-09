var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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


//Minimal api

app.MapGet("/animals", () =>
{
   // 200 - Ok
   // 400 - Bad request
   // 404 - Not Found
   // 401 - Unauthorized
    return Results.Ok(); 
});
app.MapGet("/animals", () =>
{

});



app.Run();
