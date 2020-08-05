using System;

namespace lesson1
{
    class Bday
    {
        DateTime birthday;
        int y;
        int age;

        public string ToString() {
            return birthday.ToString();
        }
        public void Enter() {
            Console.WriteLine("Hello, enter the year of your birthday please:");
            string s = System.Console.ReadLine();

<<<<<<< HEAD
=======
            Console.WriteLine(s);
>>>>>>> adb1982d8cf5a2631a835b1ffe74c42426c886c0
            this.y = Convert.ToInt32(s);

            DateTime dat = DateTime.Now;

            if ( y >= dat.Year) {
                Console.WriteLine("You are not born yet. Error.");
                return;
            } else if (y+135 < dat.Year) {
                Console.WriteLine("You are not honest. How can you be 135 year old, or older!");
                return;
            }
            age = dat.Year - y;

            Console.WriteLine("You are {0:G} years old", age);
        }
        static void Main(string[] args)
        {
            Bday bday = new Bday();

            DateTime dat = DateTime.Now;

            Console.WriteLine("\nToday is {0:d} at {0:T}.", dat);
            Console.Write("\nPress any key to continue... ");
            Console.ReadLine();

            bday.Enter();
        }
    }
}
