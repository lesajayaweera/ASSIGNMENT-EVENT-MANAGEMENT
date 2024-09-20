using Assignment_Sdam.Forms.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Sdam
{
    public partial class AdminDashboard : Form
    {

        private string username;
        private Person person;
        private Form form;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public AdminDashboard(Person person,Form form)
        {
            InitializeComponent();
            this.username = person.Name;
            this.person = person;
            this.form = form;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            UsernameLabel_ADashboard.Text = $"Hi ! {username},";
            Database d1 = new Database();
            d1.DisplayAllEvents(dataGridView_ADashboard);
        }

        private void signoutButton_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Do you really want to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Login login = new Login();
                this.Hide();
                login.Show();

            }
        }

        private void VeiwDatabase_Admin_Click(object sender, EventArgs e)
        {
            ViewDatabase v1 = new ViewDatabase(person, this);
            v1.Show();
            this.Hide();

        }

        private void EventManagement_Admin_Click(object sender, EventArgs e)
        {
            EventManagement e1 = new EventManagement(person, this);
            e1.Show();
            this.Hide();
        }

        private void UserManagement_Admin_Click(object sender, EventArgs e)
        {
            UserManagement u1  = new UserManagement(person, this);
            u1.Show();
            this.Hide();

        }
    }
}
