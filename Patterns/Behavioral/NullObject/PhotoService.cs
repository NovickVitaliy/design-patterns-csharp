using Patterns.Behavioral.NullObject.Implementations;
using Patterns.Behavioral.NullObject.Models;

namespace Patterns.Behavioral.NullObject;

public class PhotoService
{
    private readonly List<User> _users;

    public PhotoService()
    {
        _users = UserDatabase.Users;
    }

    public void SetPhoto(Photo photo, int userId)
    {
        var user = _users.Single(user => user.Id == userId);

        user.Photo = photo;
    }
}