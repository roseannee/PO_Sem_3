using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Calculator : Form
    {
        double number1, number2, answer;

        public Calculator()
        {
            InitializeComponent();
        }

        private void getNumbers()
        {
            string str_num1, str_num2;

            str_num1 = tb_num1.Text;
            number1 = double.Parse(str_num1);

            str_num2 = tb_num2.Text;
            number2 = double.Parse(str_num2);
        }

        private void sings(string a)
        {
            lb_sign.Text = a;
            lb_equal.Text = "=";
        }

        private void message()
        {
            MessageBox.Show("Some text boxes are empty. " +
                    "Please enter data to continue.", "Error", MessageBoxButtons.OK);
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            if (tb_num1.Text == "" || tb_num2.Text == "") message();
            else {
                getNumbers();
                sings("+");
                answer = number1 + number2;

                tb_ans.Text = answer.ToString();
            }
        }

        private void bt_sub_Click(object sender, EventArgs e)
        {
            if (tb_num1.Text == "" || tb_num2.Text == "") message();
            else {
                getNumbers();
                sings("-");
                answer = number1 - number2;

                tb_ans.Text = answer.ToString();
            }
        }

        private void bt_mult_Click(object sender, EventArgs e)
        {
            if (tb_num1.Text == "" || tb_num2.Text == "") message();
            else {
                getNumbers();
                sings("*");
                answer = number1 * number2;

                tb_ans.Text = answer.ToString();
            }
        }

        private void bt_div_Click(object sender, EventArgs e)
        {
            if (tb_num1.Text == "" || tb_num2.Text == "") message();
            else {
                getNumbers();
                sings("/");
                answer = number1 / number2;

                tb_ans.Text = answer.ToString();
            }
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            tb_num1.Clear();
            tb_num2.Clear();
            tb_ans.Clear();

            lb_sign.Text = "";
            lb_equal.Text = "";
        }
    }
}