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
    public partial class UserManagement : Form
    {
        private Person person;
        private Form form;
        private int selected_UserId;
        private string selected_Username;
        private string selected_role;
        public UserManagement(Person person, Form form)
        {
            InitializeComponent();
            this.person = person;
            this.form = form;
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            UsernameLabel_EventManagement.Text = $"Hi ! {person.Name},";
            Database d1 = new Database();
            d1.DisplayAllUser(dataGridView_Usermanagement);
        }

        private void Home_UserManagement_Click(object sender, EventArgs e)
        {
            AdminDashboard a1 = new AdminDashboard(person, this);
            a1.Show();
            this.Hide();

        }

        private void ViewDatabase_UserManagement_Click(object sender, EventArgs e)
        {
            ViewDatabase v1 = new ViewDatabase(person, this);
            v1.Show();
            this.Hide();
        }

        private void EventManagement_UserManagement_Click(object sender, EventArgs e)
        {
            EventManagement e1 = new EventManagement(person, this);
            e1.Show();
            this.Hide();
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

        private void dataGridView_Usermanagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView_Usermanagement.Rows[e.RowIndex];

                // Retrieve the EventId (assuming it's stored in a column named "EventId")
                selected_UserId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                // Retrieve the EventName (assuming it's stored in a column named "EventName")
                selected_Username = selectedRow.Cells["name"].Value.ToString();
                selected_role = selectedRow.Cells["role"].Value.ToString();

                MessageBox.Show($"Selected event Id ={selected_UserId}  and selected event name = {selected_Username}");

            }
        }

        private void DeleteUser_UserManagement_Click(object sender, EventArgs e)
        {
            if (selected_UserId != 0)
            {
                
                if (selected_role == "Organizer")
                {
                    Database database = new Database();
                    database.DeleteOrganizerAndEvents(selected_Username);
                    database.DisplayAllUser(dataGridView_Usermanagement);
                }
                else
                {
                    Database d1 = new Database();
                    d1.DeleteUser(dataGridView_Usermanagement, selected_UserId);
                }
            }
            else
            {
                MessageBox.Show("Please Select an event to Veiw Details!", "Select an Event", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
