using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Using the chain of responsibility pattern.

//This is a behavioral pattern.

//This pattern can be used to process a request through multiple handlers. Each handler can be set to point to another handler and the request may terminate at any point.

//https://refactoring.guru/design-patterns/chain-of-responsibility I used the request -> handler -> handler - > Ordering System diagram. I could have made an abstract handler
//to ensure each child had a private IHandler NextHandler field, but I wanted to keep this a super simple demonstration.




namespace DesignPattern
{
    internal class Program
    {
        static void Main (string[] args)
        {
            ClientHandler h1 = new ClientHandler();

            ServerHandler h2 = new ServerHandler();

            SecurityHandler h3 = new SecurityHandler();

            h1.SetNextHandler(h2);
            h2.SetNextHandler(h3);

            Credentials credentials = new Credentials("Jesse", "toast123", "gotsanity@realmail.io");
            
            User user = new User("Gotsanity", credentials);

            Request request = new Request(user, "path");

            h1.HandleRequest(request);

            Console.WriteLine("Done");

            Console.ReadLine();

        }

    }
}
