﻿using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing.Text;
using System.Reflection.Metadata.Ecma335;
using Google.Protobuf.Compiler;
using Microsoft.VisualBasic.ApplicationServices;

namespace Assignment_Sdam
{
    internal class Database
    {
        public Database() { }
        string connectionString = "Server=127.0.0.1;Database=event_management_system;User ID=root;Password=;";

        // to save the person data to the database under the user_table 
        
        

        //-------------------------------------------------------------Event Class---------------------------------------------------------------------------------------

        
       

        public void deleteEventAndTable(string eventName, int eventId)
        {
            
            string tableName = eventName.ToLower().Replace(" ", "").Replace("'", "").Replace("\"", "") + "_" + eventId.ToString();
            MessageBox.Show($"The event table is {tableName}");

            string connectionString = "Server=127.0.0.1;Database=event_management_system;User ID=root;Password=;";
            string deleteEventQuery = "DELETE FROM event_table WHERE EventId = @EventId";

            
            string dropTableQuery = $"DROP TABLE IF EXISTS `{tableName}`"; 

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    
                    using (MySqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            
                            using (MySqlCommand deleteEventCommand = new MySqlCommand(deleteEventQuery, connection, transaction))
                            {
                                deleteEventCommand.Parameters.AddWithValue("@EventId", eventId);
                                deleteEventCommand.ExecuteNonQuery();
                            }

                            // Drop the corresponding event table
                            using (MySqlCommand dropTableCommand = new MySqlCommand(dropTableQuery, connection, transaction))
                            {
                                dropTableCommand.ExecuteNonQuery();
                            }

                            // Commit the transaction if both commands succeed
                            transaction.Commit();
                            MessageBox.Show("Event deleted and table dropped successfully.");
                        }
                        catch (Exception ex)
                        {
                            // Rollback the transaction if anything goes wrong
                            transaction.Rollback();
                            MessageBox.Show("Error during transaction: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message);
            }
        }


        public void LoadOrganizerMadeEvents(DataGridView data, Person person)
        {
            
            
            string query = $"SELECT * FROM event_table WHERE EventOrganizer = '{person.Name}' ORDER BY EventOrganizer";
            DataTable dataTable = new DataTable();

            try
            {
                
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                   
                    connection.Open();

                    
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        // Fill the DataTable with the data fetched
                        adapter.Fill(dataTable);
                    }

                    // Bind the DataTable to the DataGridView
                    data.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




        //=================================================================================================================================================================
        

        

        

       


        
        


        
        
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

        public void DisplayAlltable(DataGridView datagrid)
        {
            
            // Create a new connection object
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Define the query to retrieve data
                    string query = "SELECT Id, name, email,phoneNumber, role FROM user_table";

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
        public void DisplayRelaventTable(int selectedEventId,string selectedEventName,DataGridView datagrid)
        {
            string tableName = $"{selectedEventName.ToLower().Replace(" ", "").Replace("'", "").Replace("\"", "")}_{selectedEventId}";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Define the query to retrieve data
                    string query = $"SELECT * FROM {tableName}";

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
        // to load the event data tothe event class
        public Event loadEventData(int selectedEventId, string selectedEventName)
        {
            Event eventData = null; // Create a null Event object initially
            string query = "SELECT EventId, EventName,EventOrganizer,EventLocation ,Time FROM event_table WHERE EventId = @EventId AND EventName = @EventName";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EventId", selectedEventId);
                cmd.Parameters.AddWithValue("@EventName", selectedEventName);

                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Populate the Event object with data from the database
                        eventData = new Event
                        {
                            EventId = reader.GetInt32("EventId"),
                            Organizer = reader.GetString("EventOrganizer"),
                            EventName = reader.GetString("EventName"),
                            eventtime = reader.GetDateTime("Time"),
                            EventLocation = reader.GetString("EventLocation")
                            // Set other properties as needed
                        };
                    }
                }
            }

            return eventData; // Return the populated Event object or null if not found
        }

        // to kick the user from the relavent Event
        public void KickUser(int selectedEventId, string selectedEventName, int selectedUserId,string selectedUsername,DataGridView datagrid) 
        {
            string tableName = $"{selectedEventName.ToLower().Replace(" ", "").Replace("'", "").Replace("\"", "")}_{selectedEventId}";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string deleteQuery = $"DELETE FROM {tableName} WHERE UserTable_ID = @UserId";
                    using (MySqlCommand delete = new MySqlCommand(deleteQuery, connection))
                    {
                        delete.Parameters.AddWithValue("@UserId", selectedUserId);
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
                    DisplayRelaventTable(selectedEventId, selectedEventName, datagrid);


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

        // participant
        


        // Admin
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










    }

}
