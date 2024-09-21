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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Assignment_Sdam
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
            

            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string Username = UsernameText_login.Text;
            string Password = PasswordText_login.Text;
            string Role = Admin_RadioBtn.Checked ? Admin_RadioBtn.Text :
                          Organizer_RadioBtn.Checked ? Organizer_RadioBtn.Text :
                          Participant_RadioBtn.Checked ? Participant_RadioBtn.Text : "No option selected";

            
            if (Role == "Admin")
            {
                AdminController admin = new AdminController();
                admin.Login(Username, Password,Role,this);
            }
            else if (Role == "Organizer")
            {
                OrganizerController organizer = new OrganizerController();
                
                organizer.Login(Username, Password,Role,this);
               
            }
            else if (Role == "Participant")
            {
                ParticipantController participant = new ParticipantController();
                

                participant.Login(Username, Password, Role, this);
            }
            else
            {
                MessageBox.Show("Please Select the role", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ShowPasswordCheck_CheckedChanged(object sender, EventArgs e)
        {
            PasswordText_login.PasswordChar = ShowPasswordCheck_login.Checked ? '\0' : '*';
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

