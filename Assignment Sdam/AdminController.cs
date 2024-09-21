using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Sdam
{
    internal class AdminController
    {
        private Admin admin = new Admin();
        public AdminController() { }

        public void Login(string username, string password, string role, Form form)
        {
            Person admin = new Admin(username, password, role);
            
            admin.Login(admin, form);
        }

        public void Register(string name, string email, string phoneNo, string role, string password,Form form)
        {
            Person admin = new Admin(name,email,phoneNo,role,password);
            admin.Register(admin, form);
        }
        public void DeleteEvent(string Eventname, int EventId,DataGridView datagrid)
        {
            EventController controller = new EventController();
            controller.DeleteEvents(Eventname, EventId);
            controller.DisplayEvent(datagrid);
            
        }
        public void ViewUserTable(DataGridView datagrid)
        {
            admin.DisplayAllUser(datagrid);
        }

        public void DeleteUsers(string selectedUsername, string selectedRole,int selectedId,DataGridView datagrid)
        {

            if (selectedId != 0)
            {

                if (selectedRole == "Organizer")
                {
                    
                    admin.DeleteOrganizerAndEvents(selectedUsername);
                    admin.DisplayAllUser(datagrid);
                }
                else
                {
                    
                    admin.DeleteUser(datagrid, selectedId);
                }
            }
            else
            {
                MessageBox.Show("Please Select an event to Veiw Details!", "Select an Event", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public void KickUserFromEvent(int selectedEventId, string selectedEventName, int selectedUserId, string selectedUsername, DataGridView datagrid)
        {
            EventController controller = new EventController();

            if (selectedUserId != 0)
            {
                controller.KickUser(selectedEventId, selectedEventName, selectedUserId, selectedUsername, datagrid);
            }
            else
            {
                MessageBox.Show("Please Select an event to Veiw Details!", "Select an Event", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }

}
