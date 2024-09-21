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
        private Event Ceromony = new Event();
        private Person person;

        public EventController() { }
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
                OrganizerDashboard o1 = new OrganizerDashboard(person);
                o1.Show();
                form.Hide();    
            }
        }
        public void UpdateEvent(int eventid,string eventname, string organizer, string eventlocation, decimal eventparticipants, DateTime eventtime, DateTime eventdeadline, Form form)
        {
            Ceromony = new Event(eventid,eventname, organizer, eventlocation, eventparticipants, eventtime, eventdeadline);
            bool isvalidateEventData = Ceromony.ValidateEventData(Ceromony);
            if (isvalidateEventData) 
            {
                Ceromony.UpdateEvent(Ceromony);
                OrganizerDashboard o1 = new OrganizerDashboard(person);
                o1.Show();
                form.Hide();
            }

        }
        public void DisplayEvent(DataGridView data)
        {

            Ceromony.DisplayAllEvents(data);
        }
        public void DeleteEvents(string EventName, int EventId)
        {
            Ceromony.deleteEventAndTable(EventName, EventId);
        }

        public void DisplayRelaventTable(int selectedEventId, string selectedEventName, DataGridView datagrid)
        {
            Ceromony.DisplayRelaventTable(selectedEventId, selectedEventName, datagrid);
        }
        public Event LoadEvents(int selectedEventId, string selectedEventName)
        {
            Event EventData=Ceromony.loadEventData(selectedEventId, selectedEventName); 
            return EventData;
        }

        public void KickUser(int selectedEventId, string selectedEventName, int selectedUserId, string selectedUsername, DataGridView datagrid)
        {
            Ceromony.KickUser(selectedEventId, selectedEventName, selectedUserId, selectedUsername, datagrid);
        }

    }
}
