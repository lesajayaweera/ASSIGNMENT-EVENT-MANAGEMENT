using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Sdam
{
    internal class EventController
    {
        string connectionString = "Server=127.0.0.1;Database=event_management_system;User ID=root;Password=;";
        private Event Ceromony;
        private Person person;

        public EventController(Person person)
        {
            this.person = person;
        }

        public void SaveEvent(string eventname, string organizer, string eventlocation,decimal eventparticipants, DateTime eventtime, DateTime eventdeadline,Form form)
        {
            
            Ceromony = new Event(eventname, organizer, eventlocation, eventparticipants, eventtime, eventdeadline);
            bool isvalidateEventData = Ceromony.ValidateEventData(Ceromony);
            if (isvalidateEventData)
            {
                
                Ceromony.SaveEvent(Ceromony);
                Ceromony.CreateTable(Ceromony);
                MessageBox.Show("Event SucessFully created!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OrganizerDashboard o1 = new OrganizerDashboard(person);
                o1.Show();
                form.Hide();    
                
            }
        }




    }
}
