using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Application.Session
{
    public class UserSession
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = string.Empty;
    }
}
