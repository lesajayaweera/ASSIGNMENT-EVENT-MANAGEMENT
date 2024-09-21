using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Sdam
{
    internal class Participant : Person
    {
        string connectionString = "Server=127.0.0.1;Database=event_management_system;User ID=root;Password=;";
        public Participant(string name,string email, string phoneNo, string role,string password):base(name,email,phoneNo,role, password) { }
        public Participant(string name, string password,string role):base(name,password,role) { }
        public Participant() { }
        public override void Register(Person person , Form form)
        {
           
            bool isValidated = person.ValidateData();
            bool iscredentialtaken = person.CredentialsExist(person);
            if (isValidated) 
            {
                if (!iscredentialtaken) 
                {
                    person.SaveData(person);
                    MessageBox.Show("Account Creation was sucessful!", "Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ParticipantDashboard p1 = new ParticipantDashboard(person, form);
                    form.Hide();
                    p1.Show();
                }
            }
        }
        public override void Login(Person p1, Form F1)
        {
            bool isAuthenticated = p1.AuthenticateUser(p1);

            if (isAuthenticated)
            {
                MessageBox.Show("Logged in SucessFully!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ParticipantDashboard o1 = new ParticipantDashboard(p1,F1);
                o1.Show();
                F1.Hide();
            }
            else
            {
                MessageBox.Show("Logged in Failed!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }




        // ------\
        public void SavePersontoEvent(Person person, string tableName)
        {
            int UserTableId = GetParticipantId(person);
            Participant p1 = GetPerson(UserTableId);



            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = $"INSERT INTO {tableName} (UserTable_ID, name, email, telno) VALUES (@UserTable_ID, @name, @email, @telno)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserTable_ID", UserTableId);
                        command.Parameters.AddWithValue("@name", p1.Name);
                        command.Parameters.AddWithValue("@email", p1.Email);
                        command.Parameters.AddWithValue("@telno", p1.PhoneNo); // Ensure 'PhoneNo' matches your column name


                        int rowsAffected = command.ExecuteNonQuery();
                        //MessageBox.Show("Rows affected: " + rowsAffected);

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
        private int GetParticipantId(Person person)
        {
            int userId = -1; // Default value in case user is not found

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Id FROM user_table WHERE name = @username AND role = 'Participant'";


                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", person.Name);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        userId = Convert.ToInt32(result); // If a match is found, return the UserId
                    }
                    else
                    {
                        MessageBox.Show("User didnot found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return userId; // Return -1 if the user was not found
        }

        public bool GetSpecificTable(string tableName)
        {
            bool exists = false;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();
                string query = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = @tableName";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tableName", tableName);
                    exists = Convert.ToInt32(command.ExecuteScalar()) > 0;
                }

            }
            return exists;

        }

        private Participant GetPerson(int id)
        {
            Participant person = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM user_table WHERE Id = @UserId AND role = 'Participant'";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", id);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                person = new Participant();

                                person.Name = reader["name"].ToString();
                                person.Email = reader["email"].ToString();
                                person.PhoneNo = reader["phoneNumber"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return person;
        }

        public bool HasParticipantAlreadyJoined(Person person, string selectedEventName, int selectedEventId)
        {
            int userId = GetParticipantId(person);

            string eventTableName = $"{selectedEventName.ToLower().Replace(" ", "").Replace("'", "").Replace("\"", "")}_{selectedEventId}";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = $"SELECT COUNT(*) FROM {eventTableName} WHERE UserTable_ID = @UserId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserId", userId);

                        connection.Open();
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        connection.Close();

                        return count > 0;
                    }
                }
                catch (MySqlException ex)
                {

                    MessageBox.Show($"An error occurred while checking participant status: {ex.Message}");
                    return false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"An unexpected error occurred: {ex.Message}");
                    return false;
                }
                finally
                {


                    connection.Close();

                }
            }
        }
        public bool isFull(Event ceromony)
        {
            // Construct the table name by sanitizing the EventName
            string tablename = $"{ceromony.EventName.ToLower().Replace(" ", "").Replace("'", "").Replace("\"", "")}_{ceromony.EventId}";

            // Query to count rows from the event's participants table
            string tableRowCountQuery = $"SELECT COUNT(*) FROM {tablename}";

            // Query to get the maximum participants allowed for the event from the event_table
            string eventTableCountQuery = $"SELECT NParticipants FROM event_table WHERE EventId = @ID";

            int tableRowCount = 0;
            int eventMaxParticipants = 0;

            // Using MySQL connection
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Fetch max participants allowed from the event_table
                    using (MySqlCommand eventTableCmd = new MySqlCommand(eventTableCountQuery, connection))
                    {
                        eventTableCmd.Parameters.AddWithValue("@ID", ceromony.EventId);

                        object maxParticipantsResult = eventTableCmd.ExecuteScalar();

                        // Ensure we have a valid result
                        if (maxParticipantsResult != null && int.TryParse(maxParticipantsResult.ToString(), out eventMaxParticipants))
                        {
                            // Fetch the current number of participants from the event-specific table
                            using (MySqlCommand tableRowCountCmd = new MySqlCommand(tableRowCountQuery, connection))
                            {
                                object rowCountResult = tableRowCountCmd.ExecuteScalar();

                                // Ensure we have a valid result for the row count
                                if (rowCountResult != null && int.TryParse(rowCountResult.ToString(), out tableRowCount))
                                {
                                    // Return true if the number of participants has reached the max limit
                                    return tableRowCount >= eventMaxParticipants;
                                }
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    // Handle MySQL-specific exceptions
                    MessageBox.Show("An error occurred while interacting with the database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    // Handle general exceptions
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Ensure connection is closed
                    connection.Close();
                }
            }

            // Return false if any error occurs or in case of invalid data
            return false;
        }
        public void PopulateEventDataGrid(DataGridView datagrid, Person person)
        {
            int userId = GetParticipantId(person);

            if (userId == -1)
            {
                MessageBox.Show("Invalid participant ID.");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create a DataTable to hold the event data
                    DataTable eventTable = new DataTable();

                    // Add columns to the DataTable
                    eventTable.Columns.Add("EventName", typeof(string));
                    eventTable.Columns.Add("EventId", typeof(int));
                    eventTable.Columns.Add("EventLocation", typeof(string));
                    eventTable.Columns.Add("Time", typeof(DateTime));
                    eventTable.Columns.Add("EventOrganizer", typeof(string));

                    // Query to get event names, IDs, location, time, and organizer from the event_table
                    string query = "SELECT EventName, EventId, EventLocation, Time, EventOrganizer FROM event_table";

                    // Store events temporarily
                    List<(string eventName, int eventId, string eventLocation, DateTime eventTime, string eventOrganizer)> eventList
                        = new List<(string, int, string, DateTime, string)>();

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Iterate through each event and store it in the list
                            while (reader.Read())
                            {
                                string eventName = reader["EventName"].ToString();
                                int eventId = Convert.ToInt32(reader["EventId"]);
                                string eventLocation = reader["EventLocation"].ToString();
                                DateTime eventTime = Convert.ToDateTime(reader["Time"]);
                                string eventOrganizer = reader["EventOrganizer"].ToString();

                                eventList.Add((eventName, eventId, eventLocation, eventTime, eventOrganizer));
                            }
                        }
                    }

                    // Check for user participation in each event table
                    foreach (var eventData in eventList)
                    {
                        string eventTableName = $"`{eventData.eventName.ToLower().Replace(" ", "").Replace("'", "").Replace("\"", "")}_{eventData.eventId}`";
                        string checkUserQuery = $"SELECT 1 FROM {eventTableName} WHERE UserTable_ID = @UserId";

                        using (MySqlCommand userCmd = new MySqlCommand(checkUserQuery, connection))
                        {
                            userCmd.Parameters.AddWithValue("@UserId", userId);
                            var result = userCmd.ExecuteScalar();

                            if (result != null) // User is part of this event
                            {
                                // Add the event data to the DataTable
                                eventTable.Rows.Add(eventData.eventName, eventData.eventId, eventData.eventLocation, eventData.eventTime, eventData.eventOrganizer);
                            }
                        }
                    }

                    datagrid.DataSource = eventTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void UnassignUserFromEvent(string selectedEventName, int selectedEventId, Person person, DataGridView datagrid)
        {
            int userId = GetParticipantId(person);

            string tableName = $"{selectedEventName.ToLower().Replace(" ", "").Replace("'", "").Replace("\"", "")}_{selectedEventId}";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string deleteQuery = $"DELETE FROM {tableName} WHERE UserTable_ID = @UserId";
                    using (MySqlCommand delete = new MySqlCommand(deleteQuery, connection))
                    {
                        delete.Parameters.AddWithValue("@UserId", userId);
                        delete.ExecuteNonQuery();
                    }
                    MessageBox.Show("You sucessfully UnAssigned the Event!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connection.Close();
                    PopulateEventDataGrid(datagrid, person);
                }
            }

        }

    }
}
