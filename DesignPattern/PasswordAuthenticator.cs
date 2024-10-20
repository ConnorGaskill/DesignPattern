using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    static class PasswordAuthenticator
    {
        public static void AuthenticateUser (User user)
        {
            
             string userInput = Console.ReadLine();

            if (user.Credentials.Password.Equals(userInput)){

                user.Credentials.IsActive = true;
            }

            return;

        }
    }
}
