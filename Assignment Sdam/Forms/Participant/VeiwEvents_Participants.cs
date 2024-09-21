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
    public partial class VeiwEvents_Participants : Form
    {
        private Person person;
        private Form form;
        private EventController e1;

        public VeiwEvents_Participants(Person person, Form form)
        {
            InitializeComponent();
            this.person = person;
            this.form = form;
        }

        private void VeiwEvents_Participants_Load(object sender, EventArgs e)
        {
            EventController e1 = new EventController(person);
            e1.DisplayEvent(VeiwEvent_DataGrid_Participant);
        }

        private void HomeDashboardbtn_Veiw_Events_Click(object sender, EventArgs e)
        {
            ParticipantDashboard p1 = new ParticipantDashboard(person, this);
            p1.Show();
            this.Hide();
        }

        private void JoinEventsbtn_Veiw_Events_participant_Click(object sender, EventArgs e)
        {
            JoinEvents j1 = new JoinEvents(person, this);
            j1.Show();
            this.Hide();
        }

        private void UnassignEventBtn_ViewEvents_participant_Click(object sender, EventArgs e)
        {
            UnassignEvents u1 = new UnassignEvents(person, this);
            u1.Show();
            this.Hide();
        }
    }
}
