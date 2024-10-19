using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Credentials credentials = new Credentials("Jesse", "helloworld123", "gotsanity@realmail.io");
            
            User user = new User("Gotsanity", credentials);

            Request request = new Request(user, "path");

            h1.HandleRequest(request);

            Console.WriteLine("Done");

            Console.ReadLine();



        }


    }
}
