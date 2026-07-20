namespace DinerFlow.User;

public static class UserEndpoints
{
    // TODO: Implement Dto for all paths.
    // Ensure we aren't sending over sensitive data.
    // Be explicit with what is returned.
    // Create a ToDto private static method.
    public static void MapUserEndpoints(this WebApplication app)
    {
        var userGroup = app.MapGroup("/users").WithTags("Users");

        userGroup.MapGet("/", HandleGetAllUsers);
        userGroup.MapGet("/{id:int}", HandleGetUserById);
        userGroup.MapPost("/", HandleCreateUser);
        userGroup.MapPut("/", HandleUpdateUser);
        userGroup.MapPut("/{id:int}", HandleDeleteUser);
    }

    private static async Task<IResult> HandleGetAllUsers(IUserRepository userRepository)
    {
        var users = await userRepository.GetAllUsersAsync();
        return Results.Ok(users);
    }

    private static async Task<IResult> HandleGetUserById(IUserRepository userRepository)
    {
        var user = await userRepository.GetUserByIdAsync(int id);
        return user is null ? Results.NotFound() : Results.Ok(user);
    }

    private static async Task<IResult> HandleCreateUser(IUserRepository userRepository)
    {
        var user = await userRepository.CreateUserAsync(null);
        return Results.Ok(user);
    }

    private static async Task<IResult> HandleUpdateUser(IUserRepository userRepository)
    {
        var user = await userRepository.UpdateUserAsync(null);
        return Results.Ok(user);
    }

    private static async Task<IResult> HandleDeleteUser(IUserRepository userRepository)
    {
        var result = await userRepository.DeleteUserAsync(int id);
        return result ? Results.Ok() : Results.UnprocessableEntity();
    }
}
