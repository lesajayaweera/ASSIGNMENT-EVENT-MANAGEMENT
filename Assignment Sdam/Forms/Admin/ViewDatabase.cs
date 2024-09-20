using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignment_Sdam.Forms.Admin
{
    public partial class ViewDatabase : Form
    {
        private Person person;
        private Form form;
        public ViewDatabase(Person person, Form form)
        {
            InitializeComponent();
            this.person = person;
            this.form = form;
        }

        private void ViewDatabase_Load(object sender, EventArgs e)
        {
            UsernameLabel_ViewDatabase.Text= $"Hi ! {person.Name},";
            Database d1 = new Database();
            d1.DisplayAllEvents(dataGridView_Events);
            d1.DisplayAlltable(dataGridView_User);

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

        private void Home_ViewDatabase_Click(object sender, EventArgs e)
        {
            AdminDashboard a1 = new AdminDashboard(person, this);
            a1.Show();
            this.Hide();
        }

        private void EventManagement_VeiwDatabase_Click(object sender, EventArgs e)
        {
            EventManagement e1 = new EventManagement(person, this);
            e1.Show();
            this.Hide();
        }

        private void UserManagement_ViewDashboard_Click(object sender, EventArgs e)
        {
            UserManagement u1 = new UserManagement(person, this);   
            u1.Show();
            this.Hide();

        }
    }
}
