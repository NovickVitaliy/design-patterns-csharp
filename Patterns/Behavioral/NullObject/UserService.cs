using Patterns.Behavioral.NullObject.Models;

namespace Patterns.Behavioral.NullObject;

public class UserService
{
    private readonly List<User> _users;

    public UserService()
    {
        _users = UserDatabase.Users;
    }
    
    public void RegisterUser(string username)
    {
        User newUser = new User()
        {
            Username = username
        };
        
        _users.Add(newUser);
    }

    public User GetUser(int id)
    {
        return _users.Single(user => user.Id == id);
    }
}