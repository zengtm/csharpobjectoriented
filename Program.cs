using System;

namespace myapp
{

    public class Unit
    {

        private int x;
        private int y;
        private string unitGraphic = "@";

        public void SetPosition(int x, int y)
        {

            if (x >= 0 && x < Console.WindowWidth &&
                y >= 0 && y < Console.WindowHeight)
            {
                this.x = x;
                this.y = y;
            } else
            {
                this.x = 0;
                this.y = 0;
            }


        }

        class Complex {
            public int IdProperty { get; }
            private float real;
            public float Real {get => real; set => real = value; }
            private float imaginary;
            public float Imaginary {get => imaginary; set => imaginary = value; }

            public Complex (float a, float b) { real = a; imaginary = b; IdProperty = 8; }
            public void Dump()
            {
                Console.WriteLine("Real {0:E}, Imaginary {1:E}", real, imaginary);
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition( this.x, this.y);
            Console.Write( this.unitGraphic);

        }
        static void Main(string[] args)
        {
            Complex c = new Complex(1, 2);
            c.Dump();

            Console.WriteLine("IdProperty is {0:G}, Real part is {1:F}",
                c.IdProperty, c.Real);

        }

    }

}
