using Google.Protobuf.Compiler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Sdam.Forms.Participant
{
    public partial class JoinEvents : Form
    {
        private Person Person;
        private Form form;
        private int selected_Id;
        private string selected_Eventname;

        public JoinEvents(Person person, Form form)
        {
            InitializeComponent();
            this.form = form;
            this.Person = person;
        }

        private void JoinEvents_Load(object sender, EventArgs e)
        {
            Database db = new Database();
            db.DisplayAllEvents(JoinEvent_DataGrid_Participant);
        }

        private void HomeDashboardbtn_Join_Events_Click(object sender, EventArgs e)
        {
            ParticipantDashboard p1 = new ParticipantDashboard(Person, this);
            this.Hide();
            p1.Show();
        }

        private void UnassignEventBtn_JoinEvents_participant_Click(object sender, EventArgs e)
        {
            UnassignEvents u1 = new UnassignEvents(Person, this);
            u1.Show();
            this.Hide();
        }

        private void signoutButton_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Login form1 = new Login();
                this.Hide();
                form1.Show();
            }
        }

        private void JoinEvent_DataGrid_Participant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = JoinEvent_DataGrid_Participant.Rows[e.RowIndex];

                // Retrieve the EventId (assuming it's stored in a column named "EventId")
                selected_Id = Convert.ToInt32(selectedRow.Cells["EventId"].Value);

                // Retrieve the EventName (assuming it's stored in a column named "EventName")
                selected_Eventname = selectedRow.Cells["EventName"].Value.ToString();

                MessageBox.Show($"Selected event Id ={selected_Id}  and selected event name = {selected_Eventname}");

            }
        }

        private void Joinbtn_JoinPage_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            
            bool hasJoinned = database.HasParticipantAlreadyJoined(Person, selected_Eventname, selected_Id);
            if (!hasJoinned)
            {
                EventController e1 = new EventController(selected_Id, selected_Eventname);
                bool isEventFull = database.isFull(e1);
                if (!isEventFull)
                {
                    e1.saveParticipantToDB(selected_Id, selected_Eventname, Person);

                }
                else
                {
                    MessageBox.Show("Event Is All ready Full!","Event Join Error",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show($"You are already has Joint to the Event({selected_Eventname}) earlier!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void ViewEventsbtn_Join_Events_participant_Click(object sender, EventArgs e)
        {
            VeiwEvents_Participants v1 = new VeiwEvents_Participants(Person,this);
            v1.Show();
            this.Hide();

        }
    }
}
