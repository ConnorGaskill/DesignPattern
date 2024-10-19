using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class ClientHandler : IHandler
    {

        private IHandler? NextHandler;

        public void HandleRequest(Request request)
        {
            Console.WriteLine("Checking connection status...");
            if (request.Accessing != null)
            {
                NextHandler?.HandleRequest(request);
                return;
            }

            Console.WriteLine("Connection failed");
            return;

        }

        public void SetNextHandler(IHandler handler)
        {
            this.NextHandler = handler;
        }
    }
}
