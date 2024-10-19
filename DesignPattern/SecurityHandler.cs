using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class SecurityHandler : IHandler
    {

        private IHandler? NextHandler;

        public void HandleRequest(Request request)
        {
            int count = 0;

            Console.WriteLine("Checking credentials...");
            while (request.User.Credentials.IsActive == false)
            {
                Console.WriteLine("Please re-enter password before continuing");

                PasswordAuthenticator.AuthenticateUser(request.User);
                count++;

                if (count == 3)
                {
                    Console.WriteLine("Failed to authenticate user");
                    return;

                }
            }


                NextHandler?.HandleRequest(request);
                return;

        }

        public void SetNextHandler(IHandler handler)
        {
            this.NextHandler = handler;
        }
    }
}
