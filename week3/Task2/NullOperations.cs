using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class NullOperations
    {
        public void PerformNullCheck()
        {
            String username = null;
            String Message = (username == null) ? "username is null" : "username is not null";
            Console.WriteLine(Message);

            String output = username ?? "Username is null";
            Console.WriteLine(output);

            String name = "Bishal";
            username ??= "Bishal";
            Console.WriteLine("Username" +username);
        }

    }
}
