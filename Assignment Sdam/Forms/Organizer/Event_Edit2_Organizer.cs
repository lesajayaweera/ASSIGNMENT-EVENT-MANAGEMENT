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
    public partial class Event_Edit2_Organizer : Form
    {
        private Person person;
        private Form form;
        private EventController Event;
        private string selected_eventName;
        private int selected_eventId;
        private DataGridView dataGrid;
        public Event_Edit2_Organizer(Person person, Form form, int selected_eventId, string selected_eventName)
        {
            InitializeComponent();
            this.person = person;
            this.form = form;
            this.selected_eventId = selected_eventId;
            this.selected_eventName = selected_eventName;
            


        }
        

        private void Event_Edit2_Organizer_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"{selected_eventId}");
            Edit_EventName_txt.Text = selected_eventName;
            Edit_EventOrganizer_txt.Text = person.Name;

            dateTimePicker_EventTime_EdiftEvents.Value = DateTime.Now;



        }

        private void BAckBtn_edit_Click(object sender, EventArgs e)
        {

            this.Hide();
            form.Show();
        }

        private void EditEventBtn_Click(object sender, EventArgs e)
        {

            string EventName = Edit_EventName_txt.Text;
            string EventOrganizer = Edit_EventOrganizer_txt.Text;
            string EventLocation = Edit_EventLocation_txt.Text;
            DateTime Eventtime = dateTimePicker_EventTime_EdiftEvents.Value;
            DateTime EventDeadline = Edit_EventDeadline_txt.Value;
            decimal Nparticipants = Convert.ToDecimal(Edit_EventParticipant_txt.Value);


            EventController ceromony = new EventController(selected_eventId, EventName, EventOrganizer, EventLocation, Nparticipants, Eventtime, EventDeadline);
            
            ceromony.UpdateEvent(ceromony);
            OrganizerDashboard o1 = new OrganizerDashboard(person);
            o1.Show();
            this.Hide();

        }

        private void DeleteBtn_Edit_Click(object sender, EventArgs e)
        {
           
        }
    }
}
