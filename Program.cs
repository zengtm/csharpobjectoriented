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
            public float real {get; set; }
            public float imaginary {get; set; }

            public Complex (float a, float b) { real = a; imaginary = b; }
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
        }

    }

}
