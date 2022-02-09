using System;
using System.Windows.Forms;

namespace lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            IntReadOnly(false);
            PeopleReadOnly(true);
        }

        private void int_ToString_bt_Click(object sender, EventArgs e)
        {
            Trojka<int> numbers = new Trojka<int>(int.Parse(tb1_1.Text), int.Parse(tb1_2.Text),
                int.Parse(tb1_3.Text));

            resultContent.Text = numbers.ToString();
        }

        private void int_Sort_bt_Click(object sender, EventArgs e)
        {
            Trojka<int> numbers = new Trojka<int>(int.Parse(tb1_1.Text), int.Parse(tb1_2.Text),
                int.Parse(tb1_3.Text));
            numbers.Sort();

            resultContent.Text = numbers.ToString();
        }

        private void person_ToString_bt_Click(object sender, EventArgs e)
        {
            Person p1 = new Person(tb1_1.Text, tb1_2.Text, int.Parse(tb1_3.Text));
            Person p2 = new Person(tb2_1.Text, tb2_2.Text, int.Parse(tb2_3.Text));
            Person p3 = new Person(tb3_1.Text, tb3_2.Text, int.Parse(tb3_3.Text));
            Trojka<Person> people = new Trojka<Person>(p1, p2, p3);

            //resultContent.Text = people.ToString();

            resultContent.Text = $"{people.A.Name} {people.A.Surname}, {people.A.Age}\n" +
                $"{people.B.Name} {people.B.Surname}, {people.B.Age}\n" +
                $"{people.C.Name} {people.C.Surname}, {people.C.Age}";
        }

        private void person_Sort_bt_Click(object sender, EventArgs e)
        {
            Person p1 = new Person(tb1_1.Text, tb1_2.Text, int.Parse(tb1_3.Text));
            Person p2 = new Person(tb2_1.Text, tb2_2.Text, int.Parse(tb2_3.Text));
            Person p3 = new Person(tb3_1.Text, tb3_2.Text, int.Parse(tb3_3.Text));
            Trojka<Person> people = new Trojka<Person>(p1, p2, p3);

            people.Sort();

            resultContent.Text = $"{people.A.Name} {people.A.Surname}, {people.A.Age}\n" +
                $"{people.B.Name} {people.B.Surname}, {people.B.Age}\n" +
                $"{people.C.Name} {people.C.Surname}, {people.C.Age}";
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tb1_1.Clear();
            tb1_2.Clear();
            tb1_3.Clear();
            tb2_1.Clear();
            tb2_2.Clear();
            tb2_3.Clear();
            tb3_1.Clear();
            tb3_2.Clear();
            tb3_3.Clear();

            resultContent.Clear();
        }

        private void integersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IntReadOnly(false);
            PeopleReadOnly(true);
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IntReadOnly(true);
            PeopleReadOnly(false);
        }

        private void IntReadOnly(bool x)
        {
            int_ToString_bt.Enabled = !x;
            int_Sort_bt.Enabled = !x;
        }

        private void PeopleReadOnly(bool x)
        {
            tb2_1.ReadOnly = x;
            tb2_2.ReadOnly = x;
            tb2_3.ReadOnly = x;
            tb3_1.ReadOnly = x;
            tb3_2.ReadOnly = x;
            tb3_3.ReadOnly = x;

            people_ToString_bt.Enabled = !x;
            people_Sort_bt.Enabled = !x;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
