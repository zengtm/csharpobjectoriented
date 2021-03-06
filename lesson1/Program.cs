﻿using System;

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

        static void ShowJagArray() {
            int[][] jag = new int[3][];
            jag[0] = new int[5];
            jag[1] = new int[4];
            jag[2] = new int[2];

            Console.WriteLine("{0}", jag.ToString());

            for (int i=0; i < jag.GetLength(0); i++)
            {
                for (int j=0; j < jag[i].Length; j++)
                {
                    Console.Write("\t{0}", jag[i][j]); // would jag[i,j] work?
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            int[,] i = {{1,0,0}, {0,1,0}, {0,0,1}};

            int len1 = i.Length;

            Console.WriteLine("len1 is {0}", len1);

            ShowJagArray();

            Bday bday = new Bday();

            DateTime dat = DateTime.Now;

            Console.WriteLine("\nToday is {0:d} at {0:T}.", dat);
            Console.Write("\nPress any key to continue... ");
            Console.ReadLine();

            bday.Enter();

            Bday b2 = new Bday();

            bday = b2;
        }
    }
}
