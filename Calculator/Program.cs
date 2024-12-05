﻿using System;


namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double num1 = 0;
            double num2 = 0;
            double result = 0;

            Console.WriteLine("------------------");
            Console.WriteLine("Welcome to C# Basic Calculator");
            Console.WriteLine("------------------");


            Console.Write("Enter number 1: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter number 2: ");
            num2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter an option: ");
            Console.WriteLine("\t+ : Add");
            Console.WriteLine("\t-: subtract");
            Console.WriteLine("\t* : multiply");
            Console.WriteLine("\t/ : Divide");

            switch (Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Your Result: {num1} + {num2} = " + result);
                    break;

                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Your Result: {num1} - {num2} = " + result);
                    break;

                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Your Result: {num1} * {num2} = " + result);
                    break;

                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"Your Result: {num1} / {num2} = " + result);
                    break;

            }


            Console.ReadKey();
        }


    }
}
