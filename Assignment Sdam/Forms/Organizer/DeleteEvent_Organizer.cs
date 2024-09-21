using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Sdam.Forms
{
    public partial class DeleteEvent_Organizer : Form
    {
        private Form form;
        private Person person;
        private string selected_eventName;
        private int selected_eventId;
        public DeleteEvent_Organizer(Person person, Form form)
        {
            this.person = person;
            this.form = form;
            InitializeComponent();
        }

        private void signoutButton_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Do you really Want to Logout ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Login logForm = new Login();

                this.Hide();
                logForm.Show();

            }
        }

        private void DeleteEvent_Organizer_Load(object sender, EventArgs e)
        {
            OrganizerController controller = new OrganizerController();
            controller.DisplayCreatedEvents(dataGrid_DeleteEvent, person);
        }

        private void BAckBtn_Click(object sender, EventArgs e)
        {

        }

        private void HomeButton_DeleteEvent_Click(object sender, EventArgs e)
        {
            this.Hide();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateEvent_Organizer c1 = new CreateEvent_Organizer(person, form);
            c1.Show();
            this.Hide();
        }

        private void dataGrid_DeleteEvent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGrid_DeleteEvent.Rows[e.RowIndex];

                // Retrieve the EventId (assuming it's stored in a column named "EventId")
                selected_eventId = Convert.ToInt32(selectedRow.Cells["EventId"].Value);

                // Retrieve the EventName (assuming it's stored in a column named "EventName")
                selected_eventName = selectedRow.Cells["EventName"].Value.ToString();

                MessageBox.Show($"Selected event Id ={selected_eventId}  and selected event name = {selected_eventName}","Selected Event Details",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
        }

        private void DeleteBtn_DeleteEvent_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show($"do you want to delete the  {selected_eventName} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                OrganizerController controller = new OrganizerController();
                
                controller.DeleteCreatedEvent(dataGrid_DeleteEvent, person, selected_eventName, selected_eventId);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
