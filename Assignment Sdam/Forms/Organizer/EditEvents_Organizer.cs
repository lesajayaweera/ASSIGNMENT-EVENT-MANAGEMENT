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

namespace Assignment_Sdam.Forms
{
    public partial class EditEvents_Organizer : Form
    {
        private Person person;
        private Form form;
        private EventController Event;
        private string selected_eventName;
        private int selected_eventId;
        public EditEvents_Organizer(Person person, Form form)
        {
            InitializeComponent();
            this.person = person;
            this.form = form;

        }

        private void EditEvents_Organizer_Load(object sender, EventArgs e)
        {
            Database d1 = new Database();
            d1.LoadOrganizerMadeEvents(EditEvent_datagrid, person);
        }

        private void EventEdit_DashBoardBtn_Click(object sender, EventArgs e)
        {
            OrganizerDashboard dashboard = new OrganizerDashboard(person);
            dashboard.Show();
            this.Hide();
        }

        private void EventEdit_CreateEventBtn_Click(object sender, EventArgs e)
        {
            CreateEvent_Organizer f1 = new CreateEvent_Organizer(person, form);
            f1.Show();
            this.Hide();
        }

        private void EventEdit_VeiwEventBtn_Click(object sender, EventArgs e)
        {
            ViewEventsOrganizer v1 = new ViewEventsOrganizer(person, this);
            this.Hide();
            v1.Show();
        }



        private void dataGridView_EventPage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
            
        }
        private void EditEventBtn_EditEvent_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Selected event Id ={selected_eventId}  and selected event name = {selected_eventName}");
            if (selected_eventId != 0)
            {
                Event_Edit2_Organizer e1 = new Event_Edit2_Organizer(person, this, selected_eventId, selected_eventName);
                e1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("the event didnt selected!", "Please Select the event!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void EditEvent_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = EditEvent_datagrid.Rows[e.RowIndex];

                // Retrieve the EventId (assuming it's stored in a column named "EventId")
                selected_eventId = Convert.ToInt32(selectedRow.Cells["EventId"].Value);

                // Retrieve the EventName (assuming it's stored in a column named "EventName")
                selected_eventName = selectedRow.Cells["EventName"].Value.ToString();

                MessageBox.Show($"Selected event Id ={selected_eventId}  and selected event name = {selected_eventName}");

            }
        }
    }
}
