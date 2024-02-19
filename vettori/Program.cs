using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vettori
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Vector v1 = new Vector(1, 3);
            Vector v2 = new Vector(3, 7);
            Console.WriteLine(v1 + v2);
            Console.ReadLine();

        }
    }
}
