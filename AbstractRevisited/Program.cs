using AbstractRevisited.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractRevisited
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculate c = new Calculate();

            Child c = new Child();

            int result = c.Add(2, 2);
            Console.WriteLine(result);

            result = c.Sub(4, 2);
            Console.WriteLine(result);
        }
    }
}
