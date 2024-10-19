using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Credentials
    {
        public string Username {  get; set; }

        public string Password { get; set; }

        public bool IsActive {  get; set; }

        public string Email { get; set; }

        public Credentials(string name, string password, string email)
        {
            this.Username = name;
            this.Password = password;
            this.IsActive = false;
            this.Email = email;
            
        }

    }
}
