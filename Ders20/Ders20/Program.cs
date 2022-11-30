using Ders20.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Ders20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "LINQ";
            IList <Student > studentList = new List<Student>()
            { 
            new Student()
            {
                StudentId= 1, StudentName="Oguzhan",Age=24,StandartId= 1,
            },
             new Student()
            {
                StudentId= 2, StudentName="Berfin",Age=22,StandartId= 2,
            },
              new Student()
            {
                StudentId= 332, StudentName="Faruk",Age=28,StandartId= 3,
            },
               new Student()
            {
                StudentId= 346, StudentName="Hatice",Age=25,StandartId= 4,
            },

            };
            //LINQ Language Integrated Query
            var studentNames = studentList.Where(s=>s.Age>22).Select(s => s.StudentName);

            foreach (var students in studentNames)
            {
                Console.WriteLine(students);
            }

            Console.ReadLine();
        }
    }
}
