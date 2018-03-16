using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace linqDemo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Student> Students = JsonToFile<Student>.ReadJson();

            var FirstNames = Students.Where(s => s.FirstName.Contains('s')).ToList();
            foreach(var student in FirstNames)
            {
                System.Console.WriteLine(student.FirstName);
            }


            // for(var i = 1; i < 9; i++)
            // {
            //     Random rand = new Random();
            //     var idx = rand.Next(0, Students.Count);
            //     string S1 = Students[idx].FirstName;
            //     Students.RemoveAt(idx);
            //     idx = rand.Next(0, Students.Count);
            //     string S2 = Students[idx].FirstName;
            //     Students.RemoveAt(idx);
            //     System.Console.WriteLine($"{S1} & {S2}");
            // }
        }
    }
}
