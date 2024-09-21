using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_Sdam
{
    internal class Event
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


        string connectionString = "Server=127.0.0.1;Database=event_management_system;User ID=root;Password=;";



        public Event() { }
        public Event(string eventname, string organizer, string eventlocation, decimal nParticipant, DateTime time, DateTime deadline)
        {
            this.EventName = eventname;
            this.Organizer = organizer;
            this.EventLocation = eventlocation;
            this.NoOfParticipants = nParticipant;
            this.EventTime = time;
            this.Deadline = deadline;
        }
        public Event(int EventId, string eventname, string organizer, string eventlocation, decimal nParticipant, DateTime time, DateTime deadline)
        {
            this.EventId = EventId;
            this.EventName = eventname;
            this.Organizer = organizer;
            this.EventLocation = eventlocation;
            this.NoOfParticipants = nParticipant;
            this.EventTime = time;
            this.Deadline = deadline;
        }

        public Event(int EventId,string eventname)
        {
            this.EventId = EventId;
            this.EventName = eventname;
        }

       
        
        public bool ValidateEventData(Event ceromony)
        {
            if (!string.IsNullOrWhiteSpace(ceromony.EventName)&& !string.IsNullOrWhiteSpace(ceromony.EventLocation)&& !string.IsNullOrWhiteSpace(ceromony.Organizer)&&(ceromony.eventtime > DateTime.Now)&&((ceromony.Deadline < ceromony.eventtime)&&(ceromony.Deadline >DateTime.Now))&&ceromony.NoOfParticipants >0)
            {
               
                return true;
            }
            else
            {
                MessageBox.Show("Data is not Validated!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        

        public void UpdateEvent(Event ceromony)
        {
            bool isDataValidated = ValidateEventData(ceromony);
            if (isDataValidated)
            {
                Database db = new Database();
                db.UpdateEvent(ceromony);
            }
        }


        public void saveParticipantToDB(int selectedId, string selectedEventName, Person person)
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
        //---

        public void SaveEvent(Event ceremony)
        {
            
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO event_table (EventId, EventName, EventLocation, NParticipants, Time, EventOrganizer, EventDeadline) VALUES (@EventId, @EventName, @EventLocation, @NParticipants, @Time, @EventOrganizer, @EventDeadline)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EventId", ceremony.EventId);
                        command.Parameters.AddWithValue("@EventName", ceremony.EventName);
                        command.Parameters.AddWithValue("@EventLocation", ceremony.EventLocation);
                        command.Parameters.AddWithValue("@NParticipants", ceremony.NoOfParticipants);
                        command.Parameters.AddWithValue("@Time", ceremony.eventtime);
                        command.Parameters.AddWithValue("@EventOrganizer", ceremony.Organizer);
                        command.Parameters.AddWithValue("@EventDeadline", ceremony.Deadline);

                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine("Rows affected: " + rowsAffected);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        private int GetEventId(Event ceremony)
        {
            int eventId = -1;
            string connectionString = "Server=127.0.0.1;Database=event_management_system;User ID=root;Password=;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT eventId FROM event_table WHERE EventName = @eventName AND EventOrganizer = @organizer";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@eventName", ceremony.EventName);
                    command.Parameters.AddWithValue("@organizer", ceremony.Organizer);

                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        eventId = Convert.ToInt32(result); // Assign the retrieved eventId
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return eventId;
        }


        // to create a seperate table when a event created to store Joined participants  data
        public void CreateTable(Event ceremony)
        {
            int eventId = GetEventId(ceremony);

            if (eventId != -1)
            {
                string connectionString = "Server=127.0.0.1;Database=event_management_system;User ID=root;Password=;";

                string createTableQuery = $@"
                CREATE TABLE `{ceremony.EventName.ToLower().Replace(" ", "").Replace("'", "").Replace("\"", "")}_{eventId}` (
                participantId INT PRIMARY KEY AUTO_INCREMENT,
                UserTable_ID INT,
                name VARCHAR(50) NOT NULL,
                email VARCHAR(50) NOT NULL,
                telno VARCHAR(15) NOT NULL,
                RegistrationDate DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
                );";



                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(createTableQuery, connection))
                        {
                            command.ExecuteNonQuery();
                            Console.WriteLine("Table created successfully.");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Event Didnot Created", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }







    }
}

