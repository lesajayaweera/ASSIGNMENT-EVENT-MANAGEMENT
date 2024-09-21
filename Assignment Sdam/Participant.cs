using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Sdam
{
    internal class Participant : Person
    {
        string connectionString = "Server=127.0.0.1;Database=event_management_system;User ID=root;Password=;";
        public Participant(string name,string email, string phoneNo, string role,string password):base(name,email,phoneNo,role, password) { }
        public Participant(string name, string password,string role):base(name,password,role) { }
        public Participant() { }
        public override void Register(Person person , Form form)
        {
           
            bool isValidated = person.ValidateData();
            bool iscredentialtaken = person.CredentialsExist(person);
            if (isValidated) 
            {
                if (!iscredentialtaken) 
                {
                    person.SaveData(person);
                    MessageBox.Show("Account Creation was sucessful!", "Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ParticipantDashboard p1 = new ParticipantDashboard(person, form);
                    form.Hide();
                    p1.Show();
                }
            }
        }
        public override void Login(Person p1, Form F1)
        {
            bool isAuthenticated = p1.AuthenticateUser(p1);

            if (isAuthenticated)
            {
                MessageBox.Show("Logged in SucessFully!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ParticipantDashboard o1 = new ParticipantDashboard(p1,F1);
                o1.Show();
                F1.Hide();
            }
            else
            {
                MessageBox.Show("Logged in Failed!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        
    }
}
