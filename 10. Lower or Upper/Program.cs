﻿using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());

            if (char.IsLower(letter))
            {
                Console.WriteLine($"lower-case");
            }
            else
            {
                Console.WriteLine($"upper-case");
            }
        }
    }
}
