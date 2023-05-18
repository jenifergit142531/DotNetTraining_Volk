using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LINQObjects
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

    }

    public class Standard
    {
        public int StandardId { get; set; }
        public string StandardName { get; set; }
    }

    internal class SmallStudent
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int StandardId { get; set; }

    }
}
