﻿using System;

namespace deliverable1_helloworld

{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Solution (1): Hello, Wolrd!");
            Console.WriteLine(" ");

            string stg = "Hello, World!";
            Console.WriteLine("solution (2): " + stg);
            Console.WriteLine(" ");

            Console.WriteLine("Enter a user's name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("The ussr's name is: " + userName);
            Console.WriteLine(" ");


            Console.WriteLine("Ente the user's age: ");
            //int age + Covert.ToInt32(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("The user's afe is: " + age);
        }
        




        




    }
}       