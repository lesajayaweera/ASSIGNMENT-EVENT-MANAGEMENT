using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Sdam
{
    internal class OrganizerController
    {
        private Organizer organizer = new Organizer();

        public OrganizerController() { }

        public void Login(string username, string password, string role, Form form) 
        {
            Person organizer = new Organizer(username,password,role);
            organizer.Login(organizer, form);
        }

        public void Register (string name, string email, string phoneNo, string role, string password, Form form)
        {
            Person organizer = new Organizer(name,email,phoneNo,role,password);
            organizer.Register(organizer,form);
        }
        public void DisplayCreatedEvents(DataGridView datagrid, Person person)
        {
            organizer.LoadOrganizerMadeEvents(datagrid, person);
        }

        public void DeleteCreatedEvent(DataGridView datagrid, Person person, string eventName, int eventId)
        {
            EventController controller = new EventController(person);
            controller.DeleteEvents(eventName, eventId);
            organizer.LoadOrganizerMadeEvents(datagrid, person);
        }

    }
}
