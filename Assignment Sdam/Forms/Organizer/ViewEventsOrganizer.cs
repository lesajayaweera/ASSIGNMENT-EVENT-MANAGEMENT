using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Sdam.Forms.Organizer
{
    public partial class ViewEventsOrganizer : Form
    {
        private Person person;
        private Form form;
        
        private int selected_eventId;
        private string selected_eventName;
        public ViewEventsOrganizer(Person person, Form form)
        {
            InitializeComponent();
            this.person = person;
            this.form = form;
        }


        private void ViewEventsOrganizer_Load(object sender, EventArgs e)
        {
            OrganizerController controller = new OrganizerController();
            controller.DisplayCreatedEvents(VeiwEvent_DataGrid, person);
        }

        private void HomeDashboardbtn_Veiw_Events_Click(object sender, EventArgs e)
        {
            OrganizerDashboard dashboard = new OrganizerDashboard(person);
            dashboard.Show();
            this.Hide();
        }

        private void CreateEventsbtn_Veiw_Events_Click(object sender, EventArgs e)
        {
            OrganizerDashboard dashboard = new OrganizerDashboard(person);
            CreateEvent_Organizer f1 = new CreateEvent_Organizer(person, dashboard);
            f1.Show();
            this.Hide();
        }

        private void DeleteEvent_ODashboard_Click(object sender, EventArgs e)
        {
            OrganizerDashboard dashboard = new OrganizerDashboard(person);

            DeleteEvent_Organizer f1 = new DeleteEvent_Organizer(person, dashboard);
            f1.Show();
            this.Hide();
        }

        private void EditbtnViewEventO_Click(object sender, EventArgs e)
        {
            EditEvents_Organizer e1 = new EditEvents_Organizer(person, this);
            e1.Show();
            this.Hide();

        }

        private void ViewEventDetailBtn_VeiwEvent_Click(object sender, EventArgs e)
        {
            ViewEventDetails v1 = new ViewEventDetails(person, this,  selected_eventId, selected_eventName);
            v1.Show();
            this.Hide();
        }

        private void VeiwEvent_DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = VeiwEvent_DataGrid.Rows[e.RowIndex];

                // Retrieve the EventId (assuming it's stored in a column named "EventId")
                selected_eventId = Convert.ToInt32(selectedRow.Cells["EventId"].Value);

                // Retrieve the EventName (assuming it's stored in a column named "EventName")
                selected_eventName = selectedRow.Cells["EventName"].Value.ToString();

                MessageBox.Show($"Selected event Id ={selected_eventName}  and selected event name = {selected_eventId}","Event Selection",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
        }
    }
}
