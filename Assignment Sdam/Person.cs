using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Sdam
{
    public abstract class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string phoneNo;
        public string PhoneNo
        {
            get { return phoneNo; }
            set { phoneNo = value; }
        }

        private string role;
        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }


        private string connectionString = "Server=127.0.0.1;Database=event_management_system;User ID=root;Password=;";



        public Person(string name, string email, string phoneNo, string role, string password)
        {
            this.name = name; // Assigning parameters to fields
            this.email = email;
            this.phoneNo = phoneNo;
            this.role = role;
            this.password = password;
        }

        public Person(string name, string password, string role)
        {
            this.name = name;
            this.password = password;
            this.role = role;
        }

        public Person() { }
        

        public abstract void Register(Person person ,Form form);
        public abstract void Login(Person p1, Form F1);


        
        public bool ValidateData()
        {
            if (Validateusername() && Validateemail() && Validatephone() && validatePassword())
            {
                
                return true;
            }
            else
            {
               
                return false;
            }
        }

        public bool Validateusername()
        {
            // Updated validation logic
            if (!string.IsNullOrWhiteSpace(Name) && (Name.Length >= 5 && Name.Length<=10)  && Name.All(char.IsLetter))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Username should contain only letters and greater than 5 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public bool Validateemail()
        {
            // Updated validation logic
            if (!string.IsNullOrWhiteSpace(Email) && Email.Contains("@")&& Email.Length <=25)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Email should contain '@' and should not be empty.\nAnd need to has 25 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Validatephone()
        {
            // Updated validation logic
            if (PhoneNo.Length == 10 && PhoneNo.All(char.IsDigit))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid Phone Number! It should contain exactly 10 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool validatePassword()
        {
            // Updated validation logic
            if (Password.Length >= 8 && Password.Length <= 15 && Password.All(char.IsLetterOrDigit))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid Password! It should be between 8 and 15 characters long and contain only letters and digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        // -------------------------------------------------------------
        // to save the person data to the database under the user_table 
        public void SaveData(Person person)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO user_table (name, password, email, phonenumber, role) " +
                                   "VALUES (@name, @password, @email, @phoneNumber, @role)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Check if any required field is null or empty (optional validation)
                        if (string.IsNullOrEmpty(person.Name) || string.IsNullOrEmpty(person.Password) ||
                            string.IsNullOrEmpty(person.Email) || string.IsNullOrEmpty(person.PhoneNo) ||
                            string.IsNullOrEmpty(person.Role))
                        {
                            MessageBox.Show("Please fill in all fields before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Add parameters to the command
                        command.Parameters.AddWithValue("@name", person.Name);
                        command.Parameters.AddWithValue("@password", person.Password); // Ensure Password exists in Person class
                        command.Parameters.AddWithValue("@email", person.Email);
                        command.Parameters.AddWithValue("@phoneNumber", person.PhoneNo); // Adjust to your database field if necessary
                        command.Parameters.AddWithValue("@role", person.Role);

                        // Execute query and show rows affected
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


        // to check whether the user entered the validated data based on the Database and table user_table
        public bool AuthenticateUser(Person person)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM user_table WHERE name = @username AND password = @password AND role = @role";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", person.Name);
                        command.Parameters.AddWithValue("@password", person.Password);
                        command.Parameters.AddWithValue("@role", person.Role);

                        int countUser = Convert.ToInt32(command.ExecuteScalar());
                        return countUser > 0;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        // to check whether the user entered data exists in the database in register form
        public bool CredentialsExist(Person person)
        {
            string query = "SELECT COUNT(*) FROM user_table WHERE name = @Username OR email = @Email";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("@Username", person.Name);
                        command.Parameters.AddWithValue("@Email", person.Email);

                        
                        int userCount = Convert.ToInt32(command.ExecuteScalar());

                        
                        if (userCount > 0)
                        {
                            MessageBox.Show("The email or Username is already registered. Please try another.", "Duplicate Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("An error occurred while checking the credentials: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    connection.Close(); 
                }
            }
        }


    }
}
