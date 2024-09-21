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
        private Event Event;
        private string eventName;
        private int eventId;
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
            ViewEventDetails v1 = new ViewEventDetails(person, this);
            v1.Show();
            this.Hide();
        }
    }
}
