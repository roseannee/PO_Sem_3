using System;
using System.Windows.Forms;

namespace lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_bt_Click(object sender, EventArgs e)
        {
            sign.Text = "+";
            SetResult(Get_Num1 + Get_Num2);
        }

        private void sub_bt_Click(object sender, EventArgs e)
        {
            sign.Text = "-";
            SetResult(Get_Num1 - Get_Num2);
        }

        private void mult_bt_Click(object sender, EventArgs e)
        {
            sign.Text = "*";
            SetResult(Get_Num1 * Get_Num2);
        }

        private void div_bt_Click(object sender, EventArgs e)
        {
            sign.Text = "/";
            SetResult(Get_Num1 / Get_Num2);
        }

        private void equal_bt_Click(object sender, EventArgs e)
        {
            sign.Text = "==";
            result.Text = (Get_Num1 == Get_Num2).ToString();
        }

        private void notEqual_bt_Click(object sender, EventArgs e)
        {
            sign.Text = "!=";
            result.Text = (Get_Num1 != Get_Num2).ToString();
        }

        private void greater_bt_Click(object sender, EventArgs e)
        {
            sign.Text = ">";
            result.Text = (Get_Num1 > Get_Num2).ToString();
        }

        private void less_bt_Click(object sender, EventArgs e)
        {
            sign.Text = "<";
            result.Text = (Get_Num1 < Get_Num2).ToString();
        }

        private void Equals_bt_Click(object sender, EventArgs e)
        {
            sign.Text = "";
            result.Text = Get_Num1.Equals(Get_Num2).ToString();
        }

        private void GetHashCode_bt_Click(object sender, EventArgs e)
        {
            sign.Text = "";
            result.Text = Get_Res.GetHashCode().ToString();
        }

        private void toDouble_bt_Click(object sender, EventArgs e)
        {
            double newDouble = Get_Res;
            result.Text = newDouble.ToString();
        }

        private void toImaginary_bt_Click(object sender, EventArgs e)
        {
            SetResult((ComplexNumber) Convert.ToDouble(result.Text));
        }

        private ComplexNumber GetNumber(TextBox real, TextBox imaginary)
        {
            return new ComplexNumber(Convert.ToDouble(real.Text), Convert.ToDouble(imaginary.Text));
        }

        private ComplexNumber Get_Num1 => GetNumber(num1_Re, num1_Im);
        private ComplexNumber Get_Num2 => GetNumber(num2_Re, num2_Im);
        private ComplexNumber Get_Res => GetNumber(res_Re, res_Im);

        private void SetResult(ComplexNumber complex)
        {
            res_Re.Text = complex.array[0].ToString();
            res_Im.Text = complex.array[1].ToString();
        }

        private void clear_bt_Click(object sender, EventArgs e)
        {
            num1_Re.Clear();
            num1_Im.Clear();

            num2_Re.Clear();
            num2_Im.Clear();

            res_Re.Clear();
            res_Im.Clear();
            result.Clear();

            sign.Text = "#";
        }
    }
}
