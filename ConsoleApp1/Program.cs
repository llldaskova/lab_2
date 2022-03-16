using System;

using ConsoleApp1;

    class Program
    {
        static void Main(string[] args)
        {
             
                Console.WriteLine(RomanNumber.Add(new RomanNumber(100), new RomanNumber(5)));
                Console.WriteLine(RomanNumber.Sub(new RomanNumber(100), new RomanNumber(5)));
                Console.WriteLine(RomanNumber.Mul(new RomanNumber(100), new RomanNumber(5)));
                Console.WriteLine(RomanNumber.Div(new RomanNumber(100), new RomanNumber(5)));
                RomanNumber[] romanNumberArray = new RomanNumber[10];
                Random rnd = new Random();
                for (int i = 0; i < 10; i++)
                {
                    romanNumberArray[i] = new RomanNumber((ushort)(rnd.Next(1, 500)));
                    Console.Write(romanNumberArray[i] + " ");
                }
                Console.WriteLine();

                Array.Sort(romanNumberArray);

                for (int i = 0; i < 10; i++)
                {
                    Console.Write(romanNumberArray[i] + " ");
                }
            }
        }
   

