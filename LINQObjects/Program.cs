using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LINQObjects
{
    internal class Program
    {
        public static void MyLinqArray()
        {
            //Data source(LINQ to array)
            string[] names = { "Mira", "Mitra", "Walnut" };

            //LINQ Query
            var myQuery = from i in names
                          where i.Contains('a')
                          select i;

            //Query execution

            foreach (var name in myQuery)
            {
                Console.WriteLine(name + "");
            }

            

        }
        static void Main(string[] args)
        {
           
           // Linqlist.MyLinqList();
           /* IList<Student> students = new List<Student>()
            {
                new Student() { StudentId=101,StudentName="John",Age=19},
             new Student() { StudentId = 102, StudentName = "Amy", Age = 21 },
              new Student() { StudentId = 103, StudentName = "Steve", Age = 20 },
               new Student() { StudentId = 104, StudentName = "Ron", Age = 25 }
            };*/

           /* IList<SmallStudent> newstudents = new List<SmallStudent>()
            {
                new SmallStudent() { StudentId=101,StudentName="John",StandardId=1},
             new SmallStudent() { StudentId = 102, StudentName = "Amy", StandardId=2 },
              new SmallStudent() { StudentId = 103, StudentName = "Steve", StandardId=3 },
               new SmallStudent() { StudentId = 104, StudentName = "Ron", StandardId=2 }
            };



            IList<Standard> std = new List<Standard>()
            {
                new Standard(){StandardId=1,StandardName="First"},
                new Standard(){StandardId=2,StandardName="Second"},
                new Standard(){StandardId=3,StandardName="Third"},
            };

            var innerjoin = newstudents.Join(std,
                  student => student.StandardId,
                  standard => standard.StandardId,
                  (student, standard) => new
                  {
                      StudentName = student.StudentName,
                      StandardName = standard.StandardName
                  }); 
            foreach(var obj in innerjoin)
            {
                Console.WriteLine("{0} - {1}", obj.StudentName, obj.StandardName);
            }



           /*    var result = from s in students
                            orderby s.StudentName descending
                            select s;

            foreach(var i in result)
            {
                Console.WriteLine(i.StudentName); 
            }*/

           
            Console.ReadLine();



        }
    }
}
