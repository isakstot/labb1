﻿using System;

namespace Labb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nOfPeople = 4;
            string[] person = new string[nOfPeople];
            int[] age = new int[nOfPeople];

            for (int i = 0; i < nOfPeople; i++)
            {
                Console.Write("Skriv namnet på person " + (i + 1) + ": ");
                person[i] = Console.ReadLine();
                Console.Write("Skriv åldern på person " + (i + 1) + ": ");
                age[i] = Int32.Parse(Console.ReadLine());
            }
            
            for (int i = 0; i < nOfPeople; i++)
            {
                Console.WriteLine(person[i] + " är " + age[i] + " år gammal.");
            }
            
            int totalAge = CalculateTotal(age);
            double averageAge = CalculateAverage(age);

            Console.WriteLine($"Sammanlagd ålder: {totalAge}");
            Console.WriteLine($"Medelålder: {averageAge:F2}");


            int CalculateTotal(int[] ages)
            {
                int sum = 0;
                foreach (int age in ages)
                {
                    sum += age;
                }
                return sum;
            }

            double CalculateAverage(int[] ages)
            {
                double sum = 0;
                foreach (int age in ages)
                {
                    sum += age;
                }
                sum = sum / ages.Length;
                return(double) sum;
            }
        }
    }
} 