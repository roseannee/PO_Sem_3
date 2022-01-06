using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        Person person = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            try
            {
                person = new Person(name_tb.Text, surname_tb.Text,
                    Convert.ToInt32(weight_tb.Text), Convert.ToInt32(birthYear_tb.Text));
            }
            catch
            {
                MessageBox.Show("No data available. Enter the data in the text boxes.", ""+
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void show_button_Click(object sender, EventArgs e)
        {
            if (person != null)
            {
                name_tb.Text = person.Name;
                surname_tb.Text = person.Surname;
                weight_tb.Text = Convert.ToString(person.Weight);
                birthYear_tb.Text = Convert.ToString(person.BirthYear);
                age_tb.Text = Convert.ToString(person.Age);
            }
            else
            {
                MessageBox.Show("No data available. Enter the data in the text boxes.", "" +
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            clear_button_Click(sender, e);
            person = null;
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            name_tb.Clear();
            surname_tb.Clear();
            weight_tb.Clear();
            birthYear_tb.Clear();
            age_tb.Clear();
        }
    }

    class Person
    {
        private string _name;
        private int _weight;
        private int _birthYear;

        public Person(string name, string surname, int weight, int birthYear)
        {
            _name = name;
            Surname = surname;
            _weight = weight;
            _birthYear = birthYear;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname { get; set; }

        public int Weight
        {
            get => _weight;
            set => _weight = value;
        }

        public int BirthYear
        {
            get => _birthYear;
            private set => _birthYear = value;
        }

        public int Age { get { return DateTime.Now.Year - _birthYear; } }
    }
}
