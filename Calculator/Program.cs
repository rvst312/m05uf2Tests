﻿using System;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            float numA;
            float numB;
            char operation;
            string response;
            Console.WriteLine("Enter the first number: ");
            response = Console.ReadLine();
            numA = int.Parse(response);
            Console.WriteLine("Enter the operation: ");
            response = Console.ReadLine();
            operation = response[0];
            Console.WriteLine("Enter the second number: ");
            response = Console.ReadLine();
            numB = int.Parse(response);

            switch (operation)
            {
                case '+':
                    Console.WriteLine(Sum(numA, numB));
                    break;
                case '-':
                    Console.WriteLine(Substract(numA, numB));
                    break;
                case '/':
                    Console.WriteLine(Divide(numA, numB));
                    break;
                case '*':
                    Console.WriteLine(Multiply(numA, numB));
                    break;
                case '%':
                    Console.WriteLine(Mod(numA, numB));
                    break;
                default:
                    Console.WriteLine("Operation not available");
                    break;
            }
        }
        public static float Sum(int A, int B)
        {
            return A + B;
        }
        public static float Substract(int A, int B)
        {
            return A - B;
        }
        public static float Divide(int A, int B)
        {
            return A / B;
        }
        public static float Multiply(int A, int B)
        {
            return A * B;
        }
        public static float Mod(int A, int B)
        {
            return A % B;
        }
    }
}
