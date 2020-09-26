using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Person> persons = new List<Person>();
        private void Form1_Load(object sender, EventArgs e)
        {
            persons.Add(new Person("Jan", "Kowalski", 55, "Zdun", true));
            persons.Add(new Person("Marek", "Nowak", 35, "Programista", true));
            persons.Add(new Person("Emil", "Zatopek", 66, "Biegacz", false));
            persons.Add(new Person("Zenek", "Martyniuk", 52, "Piosenkarz", true));

            //foreach (var item in persons)
            //{
            //    lbPersons.Items.Add(item.Fname + " " + item.Lname);
            //}

            lbPersons.DataSource = persons;
            lbPersons.DisplayMember = "FullName";

            tbFname.DataBindings.Add(new Binding("Text", lbPersons.DataSource, "Fname"));
            tbLName.DataBindings.Add(new Binding("Text", lbPersons.DataSource, "Lname"));
            tbAge.DataBindings.Add(new Binding("Text", lbPersons.DataSource, "Age"));
            
            tbJob.DataBindings.Add(new Binding("Text", lbPersons.DataSource, "Job"));
            tbJob.DataBindings.Add(new Binding("Enabled", lbPersons.DataSource, "Active"));
            
        }

        private void lbPersons_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int index = lbPersons.SelectedIndex;
            //tbFname.Text = persons[index].Fname;
            //tbLName.Text = persons[index].Lname;
            //tbAge.Text = persons[index].Age.ToString();
            //tbJob.Text = persons[index].Job;
        }
    }
}
