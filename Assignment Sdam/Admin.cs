using Assignment_Sdam;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Sdam
{
    internal class Admin :Person
    {
        string connectionString = "Server=127.0.0.1;Database=event_management_system;User ID=root;Password=;";

        public Admin() { }
        public Admin(string name,string email,string phoneNo, string role,string password) : base(name, email, phoneNo, role, password) { }
        

        public Admin(string name, string password, string role) : base(name, password, role) { }

        public override void Login(Person p1, Form F1)
        {
            
            bool isAuthenticated =p1.AuthenticateUser(this);
            if (isAuthenticated)
            {
               AdminDashboard o1 = new AdminDashboard(p1,F1);
               o1.Show();
               F1.Hide();
               MessageBox.Show("Logged in SucessFully!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Logged in Failed!","Login Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        public override void Register(Person person, Form form)
        {
            
            bool isValidated = person.ValidateData();
            bool iscredentialtaken = person.CredentialsExist(person);
            

            if (isValidated)
            {
                if (!iscredentialtaken)
                {
                    person.SaveData(person);
                    MessageBox.Show("Account Creation was sucessful!", "Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminDashboard p1 = new AdminDashboard(person, form);
                    form.Hide();
                    p1.Show();
                }
                
                

            }
        }


        // ------ 
        public void DisplayAllUser(DataGridView datagrid)
        {
            string connectionString = "Server=127.0.0.1;Database=event_management_system;User ID=root;Password=;";
            // Create a new connection object
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Define the query to retrieve data
                    string query = "SELECT * FROM user_table WHERE role IN ('Participant', 'Organizer')";

                    // Create a MySqlDataAdapter
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);

                    // Create a DataTable to hold the data
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with data
                    dataAdapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    datagrid.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        public void DeleteOrganizerAndEvents(string organizerName)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // List to store event details
                    List<(string EventName, int EventId)> eventList = new List<(string, int)>();

                    // 1. Retrieve the organizer's events
                    string retrieveEventsQuery = "SELECT EventName, EventId FROM event_table WHERE EventOrganizer = @organizerName";
                    using (MySqlCommand command = new MySqlCommand(retrieveEventsQuery, connection))
                    {
                        command.Parameters.AddWithValue("@organizerName", organizerName);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string eventName = reader.GetString("EventName");
                                int eventId = reader.GetInt32("EventId");

                                // Store the event details
                                eventList.Add((eventName, eventId));
                            }
                        }
                    }

                    // Now that the reader is closed, proceed to delete the events and their tables
                    foreach (var eventInfo in eventList)
                    {
                        string eventName = eventInfo.EventName;
                        int eventId = eventInfo.EventId;

                        // Create the event table name 
                        string eventTableName = $"{eventName.ToLower().Replace(" ", "").Replace("'", "").Replace("\"", "")}_{eventId}";

                        // 2. Drop the event table (if it exists)
                        string dropTableQuery = $"DROP TABLE IF EXISTS `{eventTableName}`";
                        using (MySqlCommand dropCommand = new MySqlCommand(dropTableQuery, connection))
                        {
                            dropCommand.ExecuteNonQuery();
                        }

                        // 3. Delete the event record from event_table
                        string deleteEventQuery = "DELETE FROM event_table WHERE EventId = @EventId";
                        using (MySqlCommand deleteEventCommand = new MySqlCommand(deleteEventQuery, connection))
                        {
                            deleteEventCommand.Parameters.AddWithValue("@EventId", eventId);
                            deleteEventCommand.ExecuteNonQuery();
                        }
                    }

                    // 4. Delete the organizer's account from user_table
                    string deleteOrganizerQuery = "DELETE FROM user_table WHERE name= @name";
                    using (MySqlCommand deleteOrganizerCommand = new MySqlCommand(deleteOrganizerQuery, connection))
                    {
                        deleteOrganizerCommand.Parameters.AddWithValue("@name", organizerName);
                        deleteOrganizerCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Organizer and their events have been successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("An error occurred while deleting the organizer: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }
        public void DeleteUser(DataGridView datagrid, int selectedUserId)
        {
            MessageBox.Show(selectedUserId.ToString());
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

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

                    // Check for user participation in each event table and delete the user if they are part of it
                    foreach (var eventData in eventList)
                    {
                        // Safely construct event table name
                        string eventTableName = $"{MySqlHelper.EscapeString(eventData.eventName.ToLower().Replace(" ", "").Replace("'", "").Replace("\"", ""))}_{eventData.eventId}";
                        string checkUserQuery = $"SELECT 1 FROM {eventTableName} WHERE UserTable_ID = @UserId";

                        using (MySqlCommand userCmd = new MySqlCommand(checkUserQuery, connection))
                        {
                            userCmd.Parameters.AddWithValue("@UserId", selectedUserId);
                            var result = userCmd.ExecuteScalar();

                            if (result != null) // User is part of this event
                            {
                                // Delete the user from the event-specific table
                                string deleteUserQuery = $"DELETE FROM {eventTableName} WHERE UserTable_ID = @UserId";
                                using (MySqlCommand deleteCmd = new MySqlCommand(deleteUserQuery, connection))
                                {
                                    deleteCmd.Parameters.AddWithValue("@UserId", selectedUserId);
                                    int rowsAffected = deleteCmd.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        // Optionally log the success of the deletion for this event
                                        MessageBox.Show($"User {selectedUserId} removed from event: {eventData.eventName} (EventId: {eventData.eventId})");
                                    }
                                }
                            }
                        }
                    }

                    // Now delete the user from the user_table
                    string deleteUserFromUserTableQuery = "DELETE FROM user_table WHERE Id = @Id";
                    using (MySqlCommand deleteUserCmd = new MySqlCommand(deleteUserFromUserTableQuery, connection))
                    {
                        deleteUserCmd.Parameters.AddWithValue("@Id", selectedUserId); // Fixed the extra space after @Id
                        int rowsDeletedFromUserTable = deleteUserCmd.ExecuteNonQuery();

                        if (rowsDeletedFromUserTable > 0)
                        {
                            // Optionally log the success of the deletion from the user table
                            MessageBox.Show($"User {selectedUserId} successfully deleted from user_table.");
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


                    connection.Close();


                    // Refresh the DataGridView to reflect the updated user list
                    DisplayAllUser(datagrid);
                }
            }
        }

    }
}



