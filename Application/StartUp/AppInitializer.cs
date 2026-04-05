using ExpenseTracker.Application.Session;
using ExpenseTracker.Core.Interface;
using ExpenseTracker.Core.Models;

public class AppInitializer
{
    private readonly IUserRepository _repo;
    private readonly UserSession _session;

    public AppInitializer(IUserRepository userRepo, UserSession session)
    {
        _repo = userRepo;
        _session = session;
    }

    public void Initialize()
    {

        Console.Write("Enter your name: ");
        var name = Console.ReadLine();

        if (name != null)
        {
            var user = _repo.GetUser(name);
            if (user == null)
            {
                user = new User
                {
                    userName = name!
                };

                _repo.AddUser(user);

            }
            else
            {
                Console.WriteLine($"Welcome back {user.userName}");
            }

            //
            _session.UserName = user.userName;
            _session.UserId = user.userId;

            Console.WriteLine("User created successfully.");
        }
        else
        {
            Console.WriteLine("Please write the user name to continue");
        }
    }
}