using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Sdam
{
    public abstract class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string phoneNo;
        public string PhoneNo
        {
            get { return phoneNo; }
            set { phoneNo = value; }
        }

        private string role;
        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public Person(string name, string email, string phoneNo, string role, string password)
        {
            this.name = name; // Assigning parameters to fields
            this.email = email;
            this.phoneNo = phoneNo;
            this.role = role;
            this.password = password;
        }

        public Person(string name, string password, string role)
        {
            this.name = name;
            this.password = password;
            this.role = role;
        }

        public Person() { }
        

        public abstract void Register(Person person ,Form form);
        public abstract void Login(Person p1, Form F1);


        
        public bool ValidateData()
        {
            if (Validateusername() && Validateemail() && Validatephone() && validatePassword())
            {
                
                return true;
            }
            else
            {
               
                return false;
            }
        }

        public bool Validateusername()
        {
            // Updated validation logic
            if (!string.IsNullOrWhiteSpace(Name) && (Name.Length >= 5 && Name.Length<=10)  && Name.All(char.IsLetter))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Username should contain only letters and greater than 5 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public bool Validateemail()
        {
            // Updated validation logic
            if (!string.IsNullOrWhiteSpace(Email) && Email.Contains("@")&& Email.Length >=25)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Email should contain '@' and should not be empty.\nAnd need to has 25 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Validatephone()
        {
            // Updated validation logic
            if (PhoneNo.Length == 10 && PhoneNo.All(char.IsDigit))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid Phone Number! It should contain exactly 10 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool validatePassword()
        {
            // Updated validation logic
            if (Password.Length >= 8 && Password.Length <= 15 && Password.All(char.IsLetterOrDigit))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid Password! It should be between 8 and 15 characters long and contain only letters and digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


    }
}
