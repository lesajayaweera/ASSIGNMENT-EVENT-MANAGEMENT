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

        public Admin(string name,string email,string phoneNo, string role,string password) : base(name,email,phoneNo,role,password)
        {

        }

        public Admin(string name, string password, string role) : base(name, password, role) { }

        public override void Login(Person p1, Form F1)
        {
            Database d1 = new Database();
            bool isAuthenticated = d1.AuthenticateUser(p1);

            if (isAuthenticated)
            {
                AdminDashboard o1 = new AdminDashboard(p1,F1);
                o1.Show();
                F1.Hide();
                MessageBox.Show("Logged in SucessFully!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        public override void Register(Person person, Form form)
        {
            Database database = new Database();
            bool isValidated = person.ValidateData();
            bool iscredentialtaken = database.CredentialsExist(person);

            if (isValidated)
            {
                if (!iscredentialtaken)
                {
                    database.SaveData(person);
                    MessageBox.Show("Account Creation was sucessful!", "Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminDashboard p1 = new AdminDashboard(person, form);
                    form.Hide();
                    p1.Show();
                }
                

            }
        }
    }
}



