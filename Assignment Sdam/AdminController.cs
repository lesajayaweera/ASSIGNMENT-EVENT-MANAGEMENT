using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Sdam
{
    internal class AdminController
    {
        private Admin admin;
        public AdminController()
        {

        }


        public void Login(string username, string password, string role, Form form)
        {
            Person admin = new Admin(username, password, role);
            
            admin.Login(admin, form);
        }

        public void Register(string name, string email, string phoneNo, string role, string password,Form form)
        {
            Person admin = new Admin(name,email,phoneNo,role,password);
            admin.Register(admin, form);
        }
    }

}
