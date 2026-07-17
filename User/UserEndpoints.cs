namespace DinerFlow.User;

public static class UserEndpoints
{
    public static void MapUserEndpoints(this WebApplication app)
    {
        var userGroup = app.MapGroup("/users").WithTags("Users");

        userGroup.MapGet("/", HandleGetAllUsers);
        userGroup.MapGet("/{id:int}", HandleGetUserById);
        userGroup.MapPost("/", HandleCreateUser);
    }

    private static async Task<string> HandleGetAllUsers(IUserRepository userRepository)
    {
        return "Hello world";
    }

    private static void HandleGetUserById(IUserRepository userRepository)
    {
        
    }

    private static void HandleCreateUser(IUserRepository userRepository)
    {
        
    }
}
