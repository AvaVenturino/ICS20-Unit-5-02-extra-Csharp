// Created by: Ava Venturino
// Created on: April 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        int num;
        Console.Write("Check whether a number is positive or negative:");
        Console.ReadLine();
        Console.Write("Input an integer : ");
        num = Convert.ToInt32(Console.ReadLine());
        if (num < 0)
             Console.WriteLine("The number is negative!");
        else
             Console.WriteLine("The number is positive!");
        Console.WriteLine("\nDone.");
    }
}