using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_Sdam
{
    internal class EventController
    {
            private int eventId;

            public int EventId
            {
                get { return eventId; }
                set { eventId = value; }
            }

            private string eventName;
            public string EventName
            {
                get { return eventName; }
                set { eventName = value; }
            }
            private string eventLocation;
            public string EventLocation
            {
                get { return eventLocation; }
                set { eventLocation = value; }
            }
            private decimal noOfParticipants;
            public decimal NoOfParticipants
            {
                get { return noOfParticipants; }
                set { noOfParticipants = value; }

            }
            private string organizer;
            public string Organizer
            {
                get { return organizer; }
                set { organizer = value; }

            }

            private bool isAvailable;
            public bool IsAvailable
            {
                get { return isAvailable; }
                set { isAvailable = value; }
            }
        

            private DateTime EventTime;
            public DateTime eventtime
            {
                get { return EventTime; }
                set { EventTime = value; }

            }
            private DateTime deadline;
            public DateTime Deadline
            {
                get { return deadline; }
                set { deadline = value; }
            }

        
        public EventController() { }
        public EventController(string eventname, string organizer, string eventlocation, decimal nParticipant, DateTime time, DateTime deadline)
        {
            this.EventName = eventname;
            this.Organizer = organizer;
            this.EventLocation = eventlocation;
            this.NoOfParticipants = nParticipant;
            this.EventTime = time;
            this.Deadline = deadline;
        }
        public EventController(int EventId, string eventname, string organizer, string eventlocation, decimal nParticipant, DateTime time, DateTime deadline)
        {
            this.EventId = EventId;
            this.EventName = eventname;
            this.Organizer = organizer;
            this.EventLocation = eventlocation;
            this.NoOfParticipants = nParticipant;
            this.EventTime = time;
            this.Deadline = deadline;
        }

        public EventController(int EventId,string eventname)
        {
            this.EventId = EventId;
            this.EventName = eventname;
        }

        public EventController(string EventName,string organizer,DateTime time,string eventlocation)
        {
            this.EventName = EventName;
            this.Organizer = organizer;
            this.EventLocation = eventlocation;
            this.eventtime = time;
        }
        public void SaveEvent(EventController ceromony)
        {
            bool isvalidateEventData = ValidateEventData(ceromony);
            if (isvalidateEventData)
            {
                Database database = new Database();

                database.SaveEvent(ceromony);
                database.CreateTable(ceromony);
                MessageBox.Show("Event SucessFully created!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }

        public void UpdateEvent(EventController ceromony)
        {
            bool isDataValidated = ValidateEventData(ceromony);
            if (isDataValidated)
            {
                Database db = new Database();
                db.UpdateEvent(ceromony);
            }
        }


        public void saveParticipantToDB(int selectedId, string selectedEventName,Person person)
        {
            MessageBox.Show(person.Name);
            Database db = new Database();
            string tableName = selectedEventName.ToLower().Replace(" ", "").Replace("'", "").Replace("\"", "") + "_" + selectedId.ToString();
            MessageBox.Show($"the table name :{tableName}");
            bool tableExists = db.GetSpecificTable(tableName);
            if (tableExists)
            {
                db.SavePersontoEvent(person, tableName);
                MessageBox.Show($"User added to the {tableName}. ");
            }
            else
            {
                MessageBox.Show("Error", "user did not added to the table");
                
            }
        }
        private bool ValidateEventData(EventController ceromony)
        {
            if (!string.IsNullOrWhiteSpace(ceromony.EventName)&& !string.IsNullOrWhiteSpace(ceromony.EventLocation)&& !string.IsNullOrWhiteSpace(ceromony.Organizer)&&(ceromony.eventtime > DateTime.Now)&&((ceromony.Deadline < ceromony.eventtime)&&(ceromony.Deadline >DateTime.Now))&&ceromony.NoOfParticipants >0)
            {
                MessageBox.Show("Data is Validated!","Event Validation SucessFull", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Data is not Validated!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }







    }
}

