using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Sdam
{
    internal  class Organizer : Person 
    {
        string connectionString = "Server=127.0.0.1;Database=event_management_system;User ID=root;Password=;";


        public Organizer() { }
        public Organizer(string name, string email, string phoneNo,string role,string password) : base(name, email, phoneNo,role, password)
        {
            
        }

        public Organizer(string name, string password, string role) : base(name, password, role) { }

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
                    OrganizerDashboard p1 = new OrganizerDashboard(person);
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
                OrganizerDashboard o1 = new OrganizerDashboard(p1);
                o1.Show();
                F1.Hide();
            }
            else
            {
                MessageBox.Show("Logged in Failed!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

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












    }
}
