namespace lab05.Endpoints;

public static class AnimalEndpoints
{
    public static void MapAnimalEndpoints(this WebApplication app)
    {
        app.MapGet("/animals/{id}", (int id) =>
        {
            return Results.Ok();
        });

        app.MapGet("/animals", () =>
        {
            // 200 - Ok
            // 201 - Created
            // 400 - Bad request
            // 404 - Not Found
            // 403 - Forbidden
            // 401 - Unauthorized
            return Results.Ok(); 
        });
        app.MapPost("/animals", () =>
        {

        });
    }
}