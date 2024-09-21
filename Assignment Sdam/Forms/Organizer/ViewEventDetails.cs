using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Sdam.Forms.Organizer
{
    public partial class ViewEventDetails : Form
    {
        private Person Person;
        private Form form;
        public ViewEventDetails(Person person, Form form)
        {
            InitializeComponent();
            this.form = form;
            this.Person = person;
        }
    }
}
