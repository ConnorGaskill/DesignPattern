using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class Request
    {
        public User User { get; set; }

        public string Accessing {  get; set; }

        public Request(User user, string accessing)
        {
            this.User = user;
            this.Accessing = accessing;
            
        }

    }
}
