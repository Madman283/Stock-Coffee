using System;
using System.Collections.Generic;
using System.Text;

namespace EventDemo
{
    class Utility
    {
       public static Random RandomNumber = new Random();

        public static int GetRandomInteger(int max) => RandomNumber.Next(max);

        public static int GetRandomInteger(int min, int max) => RandomNumber.Next(min, max);

        public static void Print(string output) => Console.WriteLine(output);
        public static void ClearScreen() => Console.Clear();

    }
}
