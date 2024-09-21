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
    public partial class EventManagement : Form
    {
        private Person person;
        private Form form;
        private string username;
        private int selected_eventId;
        private string selected_eventName;
        

        public EventManagement(Person person, Form form)
        {
            InitializeComponent();
            this.person = person;
            this.form = form;
            this.username = person.Name;
        }
        

        private void EventManagement_Load(object sender, EventArgs e)
        {
            UsernameLabel_EventManagement.Text = $"Hi ! {username},";
            //dataGridView_Eventmanagement
             EventController e1 = new EventController(person);
             e1.DisplayEvent(dataGridView_Eventmanagement);
        }

        private void Home_EventManagement_Click(object sender, EventArgs e)
        {
            AdminDashboard a1 = new AdminDashboard(person, this);
            a1.Show();
            this.Hide();

        }

        private void ViewDatabase_EventManagement_Click(object sender, EventArgs e)
        {
            ViewDatabase v1 = new ViewDatabase(person, this);
            v1.Show();
            this.Hide();
        }

        private void UserManagement_EventManagement_Click(object sender, EventArgs e)
        {
            UserManagement u1 = new UserManagement(person, this);
            u1.Show();
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

        private void dataGridView_Eventmanagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView_Eventmanagement.Rows[e.RowIndex];

                // Retrieve the EventId (assuming it's stored in a column named "EventId")
                selected_eventId = Convert.ToInt32(selectedRow.Cells["EventId"].Value);

                // Retrieve the EventName (assuming it's stored in a column named "EventName")
                selected_eventName = selectedRow.Cells["EventName"].Value.ToString();

                MessageBox.Show($"Selected event Id ={selected_eventName}  and selected event name = {selected_eventId}");

            }
        }

        private void DeleteEventbtn_EventManagement_Click(object sender, EventArgs e)
        {
            if (selected_eventId != 0)
            {
                DialogResult check = MessageBox.Show($"Do you  want to delete the event:{selected_eventName}?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    AdminController controller = new AdminController();
                    controller.DeleteEvent(selected_eventName, selected_eventId, dataGridView_Eventmanagement);
                }
            }
            else
            {
                MessageBox.Show("Please Select an event to delete!", "Select an Event", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewEventDetail_EventManagement_Click(object sender, EventArgs e)
        {
            if(selected_eventId != 0)
            {
                EventDetails e1 = new EventDetails(person, this, selected_eventName, selected_eventId);
                e1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Select an event to Veiw Details!", "Select an Event", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
