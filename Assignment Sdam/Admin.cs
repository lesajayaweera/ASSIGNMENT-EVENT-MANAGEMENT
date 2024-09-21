using Assignment_Sdam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Sdam
{
    internal class Admin :Person
    {
        string connectionString = "Server=127.0.0.1;Database=event_management_system;User ID=root;Password=;";


        public Admin(string name,string email,string phoneNo, string role,string password) : base(name,email,phoneNo,role,password)
        {

        }

        public Admin(string name, string password, string role) : base(name, password, role) { }

        public override void Login(Person p1, Form F1)
        {
            
            bool isAuthenticated =p1.AuthenticateUser(this);
            if (isAuthenticated)
            {
               AdminDashboard o1 = new AdminDashboard(p1,F1);
               o1.Show();
               F1.Hide();
               MessageBox.Show("Logged in SucessFully!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Logged in Failed!","Login Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        public override void Register(Person person, Form form)
        {
            
            bool isValidated = person.ValidateData();
            bool iscredentialtaken = person.CredentialsExist(person);
            MessageBox.Show("hello");

            if (isValidated)
            {
                if (!iscredentialtaken)
                {
                    person.SaveData(person);
                    MessageBox.Show("Account Creation was sucessful!", "Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminDashboard p1 = new AdminDashboard(person, form);
                    form.Hide();
                    p1.Show();
                }
                
                

            }
        }


        // ------ 

        
    }
}



