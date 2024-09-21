using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Sdam
{
    internal class ParticipantController
    {
         Participant participant = new Participant();

        public ParticipantController() { }


        public void Login(string username, string password, string role, Form form)
        {
            Person participant = new Participant(username,password,role);
            participant.Login(participant,form);
        }
        public void Register(string name, string email, string phoneNo, string role, string password, Form form)
        {
            Person participant = new Participant(name,password,role);
            participant = new Participant(name, email,phoneNo,role,password);
            participant.Register(participant,form);

        }

        public void JoinEvents(int selectedEventid, string selectedEventname,Person person)
        {
            bool hasJoinned = participant.HasParticipantAlreadyJoined(person,selectedEventname,selectedEventid);
            if(!hasJoinned)
            {
                Event e1  = new Event(selectedEventid,selectedEventname);
                bool isEventFull = participant.isFull(e1);
                if(!isEventFull)
                {
                    string tableName = selectedEventname.ToLower().Replace(" ", "").Replace("'", "").Replace("\"", "") + "_" + selectedEventid.ToString();
                    bool tableExists = participant.GetSpecificTable(tableName);
                    if (tableExists)
                    {
                        participant.SavePersontoEvent(person, tableName);
                        MessageBox.Show($"User added to the {tableName}. ");
                    }
                    else
                    {
                        MessageBox.Show("Error", "user did not added to the table");

                    }
                }
                else
                {
                    MessageBox.Show("Event Is All ready Full!", "Event Join Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show($"You are already has Joint to the Event({selectedEventname}) earlier!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void LeaveEvents(int selectedEventid, string selectedEventname, Person person,DataGridView datagrid)
        {
            participant.UnassignUserFromEvent(selectedEventname, selectedEventid, person, datagrid);
        }

        public void DisplayJoinnedEvents(Person person,DataGridView datagrid)
        {
            participant.PopulateEventDataGrid(datagrid, person);
        }
    }
}
