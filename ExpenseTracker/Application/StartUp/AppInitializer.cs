using ExpenseTracker.Application.Session;
using ExpenseTracker.Core.Interface;
using ExpenseTracker.Core.Models;
using ExpenseTracker.Utils;

public class AppInitializer
{
    private readonly IUserRepository _repo;
    private readonly UserSession _session;
    private readonly ConsoleHelper _validator;

    public AppInitializer(IUserRepository userRepo, UserSession session, ConsoleHelper validator)
    {
        _repo = userRepo;
        _session = session;
        _validator = validator;
    }

    public void Initialize()
    {
        var name = _validator.InputGetterStr("Enter a username (Letters and numbers only, no spaces): ");

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