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
    public partial class CreateEvent_Organizer : Form
    {
        private string organizer;
        private Person person;
        private Form form;

        public string Organizer
        {
            get { return organizer; }
            set { organizer = value; }
        }
        public CreateEvent_Organizer(Person person, Form form)
        {
            InitializeComponent();
            this.organizer = person.Name;
            this.form = form;
            this.person = person;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form.Show();
            

        }

        private void CreateEvent_Organizer_Load(object sender, EventArgs e)
        {
             EventOrganizer_txt.Text = organizer;
        }

        private void CreateEventBtn_Click(object sender, EventArgs e)
        {
            string Event_name = EventName_txt.Text;
            string Event_organizer = EventOrganizer_txt.Text;
            string Eevnt_location = EventLocation_txt.Text;
            DateTime Event_time = EventDate_txt.Value;
            decimal Event_participants = EventParticipant_txt.Value;
            DateTime Event_deadline = EventDeadline_txt.Value;

            EventController ceromony= new EventController(Event_name, Event_organizer, Eevnt_location, Event_participants, Event_time,Event_deadline);
            ceromony.SaveEvent(ceromony);

            OrganizerDashboard o1 = new OrganizerDashboard(person);
            o1.Show();
            this.Hide();



        }
    }
}
