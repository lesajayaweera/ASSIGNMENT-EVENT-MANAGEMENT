using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Sdam.Forms.Participant
{
    public partial class UnassignEvents : Form
    {
        private Person person;

        private Form form;

        private int selected_eventId;
        private string selected_eventName;
        public UnassignEvents(Person person, Form form)
        {
            InitializeComponent();
            this.person = person;
            this.form = form;
        }

        private void UnassignEvents_Load(object sender, EventArgs e)
        {
            Database db = new Database();
            db.PopulateEventDataGrid(UnassignEvent_DataGrid_Participant, person);
        }

        private void HomwEventBtn_UnassignEvents_participant_Click(object sender, EventArgs e)
        {
            ParticipantDashboard p1 = new ParticipantDashboard(person, this);
            p1.Show();
            this.Hide();
        }

        private void VeiwEventBtn_UnassignEvents_participant_Click(object sender, EventArgs e)
        {
            VeiwEvents_Participants v1 = new VeiwEvents_Participants(person, this);
            v1.Show();
            this.Hide();
        }

        private void JoinEventBtn_UnassignEvents_participant_Click(object sender, EventArgs e)
        {
            JoinEvents j1 = new JoinEvents(person, this);
            j1.Show();
            this.Hide();

        }

        private void Unassignbtn_UnassignPage_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            database.UnassignUserFromEvent(selected_eventName, selected_eventId, person, UnassignEvent_DataGrid_Participant);

        }

        private void JoinEvent_DataGrid_Participant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = UnassignEvent_DataGrid_Participant.Rows[e.RowIndex];

                // Retrieve the EventId (assuming it's stored in a column named "EventId")
                selected_eventId = Convert.ToInt32(selectedRow.Cells["EventId"].Value);

                // Retrieve the EventName (assuming it's stored in a column named "EventName")
                selected_eventName = selectedRow.Cells["EventName"].Value.ToString();

                MessageBox.Show($"Selected event Id ={selected_eventId}  and selected event name = {selected_eventName}");

            }
        }

        private void signoutButton_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Do you Want to Continue?","Confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Login login  = new Login();
                login.Show();
                this.Hide();
                  
            }
        }
    }
}
