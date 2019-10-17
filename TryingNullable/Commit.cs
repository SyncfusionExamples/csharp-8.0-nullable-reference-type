using System;
using System.Collections.Generic;
using System.Text;

namespace TryingNullable
{
    class Commit
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string? CommitMessage { get; set; }

        public Commit(string userName, string password)
        {
            UserName = userName;
            Password = password;
            CommitMessage = null;
        }
    }
}
