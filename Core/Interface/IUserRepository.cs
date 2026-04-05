using ExpenseTracker.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Core.Interface
{
    public interface IUserRepository
    {
        User? GetUser(string name);
        void AddUser(User user);
    }
}
