using System.Collections.Generic;

namespace lab10
{
    internal class Trojka<T>
    {
        public Trojka(T a, T b, T c)
        {
            A = a;
            B = b;
            C = c;
        }

        public T A { get; set; }
        public T B { get; set; }
        public T C { get; set; }

        public override string ToString()
        {
            return $"({A}, {B}, {C})";
        }

        public void Sort()
        {
            List<T> list = new List<T>();

            list.Add(A);
            list.Add(B);
            list.Add(C);

            list.Sort();

            A = list[0];
            B = list[1];
            C = list[2];
        }

        public T this[int n]
        {
            get
            {
                switch (n)
                {
                    case 0:
                        return A;

                    case 1:
                        return B;

                    case 2:
                        return C;

                    default:
                        return default;
                }
            }

            set
            {
                switch (n)
                {
                    case 0:
                        A = value;
                        break;

                    case 1:
                        B = value;
                        break;

                    case 2:
                        C = value;
                        break;
                }
            }
        }
    }
}
