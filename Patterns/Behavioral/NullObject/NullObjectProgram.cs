using Patterns.Behavioral.NullObject.Implementations;

namespace Patterns.Behavioral.NullObject;

public class NullObjectProgram
{
    public static void NullObjectMain(string[] args)
    {
        UserService userService = new UserService();
        PhotoService photoService = new PhotoService();
        userService.RegisterUser("vitalii");
        userService.RegisterUser("dude");
        userService.RegisterUser("chel");

        Console.WriteLine("======================================");
        Console.WriteLine("Before setting user photo");        
        Console.WriteLine(userService.GetUser(1).Photo.Url);
        Console.WriteLine(userService.GetUser(2).Photo.Url);
        Console.WriteLine(userService.GetUser(3).Photo.Url);
        Console.WriteLine("======================================");
        
        Console.WriteLine("======================================");
        Console.WriteLine("After setting user photo");
        photoService.SetPhoto(new Photo(){Url="some/another/link"}, 1);
        photoService.SetPhoto(new Photo(){Url="some/another/link/again/bla/bla/bla"}, 3);
        Console.WriteLine(userService.GetUser(1).Photo.Url);
        Console.WriteLine(userService.GetUser(2).Photo.Url);
        Console.WriteLine(userService.GetUser(3).Photo.Url);
        Console.WriteLine("======================================");

    }
}