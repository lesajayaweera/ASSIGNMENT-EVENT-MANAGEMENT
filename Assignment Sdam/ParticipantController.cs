using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Sdam
{
    internal class ParticipantController
    {
        private Participant participant;

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
    }
}
