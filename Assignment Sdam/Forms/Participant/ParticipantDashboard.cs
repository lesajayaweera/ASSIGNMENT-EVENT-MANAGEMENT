using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Assignment_Sdam.Forms.Participant;

namespace Assignment_Sdam
{
    public partial class ParticipantDashboard : Form
    {
        private string username;
        private string role;
        private Person person;
        private Form form;

        // Getter and setters
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public ParticipantDashboard(Person p1, Form form)
        {
            InitializeComponent();



            this.username = p1.Name;
            this.role = p1.Role;
            this.person = p1;
            this.form = form;
        }

        private void ParticipantDashboard_Load(object sender, EventArgs e)
        {
            // Update the userGreetingLabel with the user's name
            userGreetingLabel.Text = "Welcome, " + username + "!";

            ParticipantController controller = new ParticipantController(); 
            controller.DisplayJoinnedEvents(person, dataGridView1 );


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Login form1 = new Login();
                this.Hide();
                form1.Show();
            }


        }

        private void ViewEventsbtn_PDashboard_participant_Click(object sender, EventArgs e)
        {
            VeiwEvents_Participants v1 = new VeiwEvents_Participants(person, this);
            v1.Show();
            this.Hide();
        }

        private void JoinBtn_PDashboard_Click(object sender, EventArgs e)
        {
            JoinEvents j1 = new JoinEvents(person, this);
            this.Hide();
            j1.Show();
        }

        private void Unassign_EventsBtn_Pdashboard_Click(object sender, EventArgs e)
        {
            UnassignEvents u1 = new UnassignEvents(person, this);
            u1.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
