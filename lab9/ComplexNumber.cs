using System;
using System.Windows.Forms;

namespace lab9
{
    internal class ComplexNumber
    {
        public double[] array = new double[2];

        public ComplexNumber(double num1, double num2)
        {
            array[0] = num1;
            array[1] = num2;
        }

        public static ComplexNumber operator +(ComplexNumber num1, ComplexNumber num2)
        {
            return new ComplexNumber(num1.array[0] + num2.array[0], num1.array[1] + num2.array[1]);
        }

        public static ComplexNumber operator -(ComplexNumber num1, ComplexNumber num2)
        {
            return new ComplexNumber(num1.array[0] - num2.array[0], num1.array[1] - num2.array[1]);
        }

        public static ComplexNumber operator *(ComplexNumber num1, ComplexNumber num2)
        {
            return new ComplexNumber(num1.array[0] * num2.array[0] - num1.array[1] * num2.array[1],
                num1.array[0] * num2.array[1] + num2.array[0] * num1.array[1]);
        }

        public static ComplexNumber operator /(ComplexNumber num1, ComplexNumber num2)
        {
            if ((num2.array[0] == 0) && (num2.array[1] == 0))
            {
                MessageBox.Show("Attempting to divide by zero. The operation is not possible.");
            }

            double real = (num1.array[0] * num2.array[0] + num1.array[1] * num2.array[1]) / (num2.array[0] * num2.array[0] + num2.array[1] * num2.array[1]);
            double imaginary = (num2.array[0] * num1.array[1] - num1.array[0] * num2.array[1]) / (num2.array[0] * num2.array[0] + num2.array[1] * num2.array[1]);

            return new ComplexNumber(real, imaginary);
        }

        public static bool operator ==(ComplexNumber num1, ComplexNumber num2)
        {
            if ((num1.array[0] == num2.array[0]) && (num1.array[1] == num2.array[1]))
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(ComplexNumber num1, ComplexNumber num2)
        {
            return !(num1 == num2);
        }

        public static bool operator >(ComplexNumber num1, ComplexNumber num2)
        {
            if (num1.array[0] > num2.array[0])
            {
                return true;
            }

            if (num1.array[1] > num2.array[1])
            {
                return true;
            }

            return false;
        }

        public static bool operator <(ComplexNumber num1, ComplexNumber num2)
        {
            if (num1.array[0] < num2.array[0])
            {
                return true;
            }

            if (num1.array[1] < num2.array[1])
            {
                return true;
            }

            return false;
        }

        public override bool Equals(object obj)
        {
            return this == (ComplexNumber) obj;
        }

        public override int GetHashCode()
        {
            return array[0].GetHashCode() ^ array[1].GetHashCode();
        }

        public static explicit operator ComplexNumber(double real)
        {
            return new ComplexNumber(real, 0);
        }

        public static implicit operator double(ComplexNumber complex)
        {
            return complex.array[0];
        }

        public double this[int nr]
        {
            get { return array[nr]; }
            set { array[nr] = value; }
        }

        public double this[char letter]
        {
            get
            {
                switch (letter)
                {
                    case 'r':
                        return array[0];

                    case 'i':
                        return array[1];

                    default:
                        return 0;
                }
            }

            set
            {
                switch (letter)
                {
                    case 'r':
                        array[0] = value;
                        break;

                    case 'i':
                        array[1] = value;
                        break;
                }
            }
        }
    }
}
