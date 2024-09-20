using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Sdam
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowPasswordCheck_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextRegistration.PasswordChar = ShowPasswordCheck.Checked ? '\0' : '*';
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string name = UsernameTextRejister.Text;
            string email = EmailText_register.Text;
            string TelNo = ContactTextRejister.Text;
            string AdminCode = AdminCodetext.Text;
            string password = PasswordTextRegistration.Text;



            Person person;

            if (ParticipantRadioCheck_Register.Checked)
            {
                person = new Participant(name, email, TelNo,"Participant" ,password);
                person.Register(person,this);
               
            }
            else if (OrganizerRadioCheckBtn_Register.Checked)
            {
                person = new Organizer(name, email, TelNo, "Organizer",password);
                person.Register(person,this);
                
            }
            else if (AdminCheckBtn_Register.Checked)
            {
                if (AdminCode == "Admin123")
                {
                    person = new Admin(name, email, TelNo,"Admin", password);
                    person.Register(person,this);
                }
                else
                {
                    MessageBox.Show("please enter the Admin Code Correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please select the role!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
