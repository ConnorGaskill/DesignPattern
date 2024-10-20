using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class User
    {

        public string Name { get; set; }

        public Credentials Credentials { get; set; }

        public User(string name, Credentials credentials)
        {
            this.Name = name;
            this.Credentials = credentials;
            
        }
    }
}
