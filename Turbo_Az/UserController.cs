using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo_Az
{
    public class UserController
    {
        public ArrayList profiles = new ArrayList();
        public void signup(string name, string surname, string email, string password)
        {
            Profile profile = new Profile(name , surname , email , password );
            profiles.Add(profile);
            Console.WriteLine("User signed successfully");
        }

        public void signin(string email , string password)
        {
            foreach (Profile item in profiles)
            {
                Profile profile =(Profile)item;

                if (profile.email.Equals(email) && profile.password.Equals(password)){
                    Console.WriteLine("signin successful" + profile.name);
                }
            }
        }
            
    }
}
