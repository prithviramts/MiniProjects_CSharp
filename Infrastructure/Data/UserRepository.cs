using ExpenseTracker.Core.Interface;
using ExpenseTracker.Core.Models;
using ExpenseTracker.Infrastructure.Data;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public User? GetUser(string name)
    {
        return _context.Set<User>().Where(e => e.userName == name).FirstOrDefault();
    }

    public void AddUser(User user)
    {
        _context.Add(user);
        _context.SaveChanges();
    }
}