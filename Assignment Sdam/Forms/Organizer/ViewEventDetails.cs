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
    public partial class ViewEventDetails : Form
    {
        private Person Person;
        private Form form;
        private int selectedEventId;
        private string selectedEventName;
        private Event ceromony;
        public ViewEventDetails(Person person, Form form, int selectedEventId, string selectedEventName)
        {
            InitializeComponent();
            this.form = form;
            this.Person = person;
            this.selectedEventId = selectedEventId;
            this.selectedEventName = selectedEventName;
        }

        private void ViewEventDetails_Load(object sender, EventArgs e)
        {
            EventController e1 = new EventController();
            e1.DisplayRelaventTable(selectedEventId, selectedEventName, dataGridView_VeiwEventDetail_Org);
            ceromony = e1.LoadEvents(selectedEventId, selectedEventName);

            EventName_label_Org.Text = $"Event Name:\n{ceromony.EventName}";
            EventOrganizerLabel_Org.Text = $"Event Organizer: \n{ceromony.Organizer}";

        }

        private void BAckBtn_ViewEventsDetails_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Hide();
        }
    }
}
