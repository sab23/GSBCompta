using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsbcompta
{
    class User
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public String Firstname { get; set; }
        public String Login { get; set; }
        private String Password { get; set; }
        public String Address { get; set; }
        public String Zip { get; set; }
        public String City { get; set; }
        public String DateEmployment { get; set; }
        public String Role { get; set; }


        public User() { }
        public User(string id, string name, string firstname, string login, string password, string address, string zip, string city, string dateEmployment, string role)
        {
            this.Id = id;
            this.Name = name;
            this.Firstname = firstname;
            this.Login = login;
            this.Password = password;
            this.Address = address;
            this.Zip = zip;
            this.City = city;
            this.DateEmployment = dateEmployment;
            this.Role = role;
        }

        public void AddUser(string id, string name, string firstname, string login, string password, string address, string zip, string city, string dateEmployment, string role)
        {
            this.Id = id;
            this.Name = name;
            this.Firstname = firstname;
            this.Login = login;
            this.Password = password;
            this.Address = address;
            this.Zip = zip;
            this.City = city;
            this.DateEmployment = dateEmployment;
            this.Role = role;
        }

        public Boolean checkPassword (string password)
        {
            if (this.Password == password) return true;
            else return false;
        }

        public override String ToString()
        {
            return Name + " " + Firstname;
        }

    }
}
