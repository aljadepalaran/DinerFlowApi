namespace DinerFlow.User;

// TODO: Implement database context
public class UserRepository : IUserRepository
{
    public async Task<List<User>> GetAllUsersAsync()
    {
        // Use database context to fetch users
        return new List<User>();
    }

    public async Task<User?> GetUserByIdAsync(int id)
    {
        return null;
    }

    public async Task<User?> CreateUserAsync(User user)
    {
        return null;
    }

    public async Task<User?> UpdateUserAsync(User user)
    {
        return null;   
    }

    public async Task<bool> DeleteUserAsync(int id)
    {
        return false;
    }
}