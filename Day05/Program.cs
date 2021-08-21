using System;
using System.Collections;
using System.Collections.Generic;

namespace Day05
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            char option = 's';

            while (char.ToLower(option) == 's'){
                var student = new Student();
                Console.Write("Student Name: ");
                student.Name = Console.ReadLine();
                Console.Write("Student ID: ");
                student.StudentId = Console.ReadLine();
                Console.WriteLine("Inform the student Grades...");
                for (int i = 0; i < 3; i++){
                    Console.WriteLine($"Grade {i + 1}: ");
                    student.Grades.Add(Convert.ToDouble(Console.ReadLine()));
                }
                students.Add(student);
                Console.Write("Would you like to add a new Student: y - yes | n - no: ");
                option = Console.ReadLine()[0];
                Console.Clear();
            }            
        }
    }
}

