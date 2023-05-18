using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQObjects
{
    internal class Linqlist
    {
        public static void MyLinqList()
        {
            List<int> ls = new List<int> { 5, 7, 13, 40, 50, 60 };
            Console.WriteLine("Element At :" +ls.ElementAt(2));
            Console.WriteLine("Element or default  :" + ls.ElementAtOrDefault(10));

            Console.WriteLine("First At :" + ls.First());
            Console.WriteLine("First even at :" + ls.First(i => i % 2 == 0));
            Console.WriteLine("First or Default :" + ls.FirstOrDefault(i => i > 100));

            Console.WriteLine("Last At :" + ls.Last());
            Console.WriteLine("Last even at :" + ls.Last(i => i % 2 == 0));
            Console.WriteLine("Last or Default :" + ls.LastOrDefault(i => i > 100));

            
            Console.WriteLine("Single even at :" + ls.Single(i => i < 7));
            Console.WriteLine("Single or Default :" + ls.SingleOrDefault(i => i < 5));

            /*Query Syntax

            IEnumerable<int> numbers = from i in ls
                                       where i > 30
                                       select i;

            Console.WriteLine("Using LINQ Query syntax");

            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }*/

            /*LINQ Method syntax - using lambda expression
            Console.WriteLine("Using LINQ Method syntax");

            var result = ls.Where(i => i > 30);

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }

            */

        }
    }
}
