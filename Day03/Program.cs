using System;
using System.Collections;
using System.Collections.Generic;

namespace Day03
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            char option = 's';

            while (option.ToLower == 's'){
                var student = new Student();
                Console.Write("Student Name: ");
                student.Name = Console.Readline();
                Console.Write("Student ID: ");
                student.StudentId = Console.Readline();
                Console.WriteLine("Inform the student Grades...");
                for (int i = 0; i < 3; i++){
                    Console.WriteLine($"Grade {i + 1}: ");
                    student.Grades.Add(Convert.ToDouble(Console.ReadLine()));
                }
                students.Add(student);

                Console.Clear();
            }
            

        }
    }
}
