using System;

namespace TryingNullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Commit initial = new Commit("Suresh", "$trongPassword123");
            int messageLength = GetMessageLength(initial);
            Console.WriteLine(messageLength);
        }

        static int GetMessageLength(Commit person)
        {
            var commitMessage = person.CommitMessage;
            if (commitMessage is null)
                return 0;
            return commitMessage.Length;
        }
    }
}
