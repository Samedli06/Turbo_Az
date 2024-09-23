using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo_Az
{
    public class Profile
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        


        public Profile(string Name, string Surname, string Email, string Password)
        {
            name = Name;
            surname = Surname;
            email = Email;
            password = Password;
    
        }


        public override string ToString()
        {
            return $"Username: {name}\nSurname: {surname}\nEmail: {email}\nPassword:{password}\n";
        }
    }
}
