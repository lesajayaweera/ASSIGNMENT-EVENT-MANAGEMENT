using Assignment_Sdam.Forms;
using Assignment_Sdam.Forms.Organizer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Sdam
{
    public partial class OrganizerDashboard : Form
    {
        private string username;
        private string role;
        private Person person;


        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Role
        {
            get
            {
                return role;
            }
            set { role = value; }
        }

        public OrganizerDashboard(Person p1)
        {
            InitializeComponent();

            this.username = p1.Name;
            this.role = p1.Role;
            this.person = p1;

        }

        private void OrganizerDashboard_Load(object sender, EventArgs e)
        {

            UsernameLabel_ODashboard.Text = $"Hi! {Username},";
            Database d1 = new Database();
            d1.DisplayAllEvents(dataGridView_ODashboard);
        }

        private void signoutButton_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Do you want to SignOut?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Login login = new Login();
                this.Hide();
                login.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateEvent_Organizer createEvent_Organizer = new CreateEvent_Organizer(person, this);
            createEvent_Organizer.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteEvent_ODashboard_Click(object sender, EventArgs e)
        {
            DeleteEvent_Organizer delete = new DeleteEvent_Organizer(person, this);
            this.Hide();
            delete.Show();
        }

        private void VeiwEvents_ODashboard_Click(object sender, EventArgs e)
        {
            ViewEventsOrganizer v1 = new ViewEventsOrganizer(person,this); 
            v1.Show();
            this.Hide();


        }

        private void EditEvents_ODashboard_Click(object sender, EventArgs e)
        {
            EditEvents_Organizer e1 = new EditEvents_Organizer(person, this);
            e1.Show();
            this.Hide();

        }
    }
}