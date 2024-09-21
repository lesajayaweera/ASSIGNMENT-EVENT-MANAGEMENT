using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Sdam.Forms.Admin
{
    public partial class EventDetails : Form
    {
        private Event ceromony;
        private Person person;
        private Form form;
        private string selectedEventName;
        private int selectedEventID;
        private string selected_UserName;
        private int selected_UserId;

        public EventDetails(Person person, Form form, string selectedEventName, int selectedEventId)
        {
            InitializeComponent();

            this.form = form;
            this.selectedEventName = selectedEventName;
            this.selectedEventID = selectedEventId;
            this.person = person;
            this.form = form;

        }

        private void EventDetails_Load(object sender, EventArgs e)
        {
            Database d1 = new Database();
            d1.DisplayRelaventTable(selectedEventID, selectedEventName, dataGridView_VeiwEventDetail);
            ceromony = d1.loadEventData(selectedEventID, selectedEventName);

            EventName_label.Text = $"Event Name:\n{ceromony.EventName}";
            EventOrganizerLabel.Text = $"Event Organizer: \n{ceromony.Organizer}";

        }

        private void BAckBtn_edit_Click(object sender, EventArgs e)
        {
            this.Hide();
            EventManagement e1 = new EventManagement(person, this);
            e1.Show();
        }

        private void dataGridView_VeiwEventDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView_VeiwEventDetail.Rows[e.RowIndex];


                selected_UserId = Convert.ToInt32(selectedRow.Cells["UserTable_ID"].Value);


                selected_UserName = selectedRow.Cells["name"].Value.ToString();

                MessageBox.Show($"Selected event Id ={selected_UserName}  and selected event name = {selected_UserId}");

            }
        }

        private void KickUserBtn_Click(object sender, EventArgs e)
        {
            if(selected_UserId != 0)
            {
                Database d1 = new Database();
                d1.KickUser(selectedEventID, selectedEventName, selected_UserId, selected_UserName, dataGridView_VeiwEventDetail);
            }
            else
            {
                MessageBox.Show("Please Select an event to Veiw Details!", "Select an Event", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
