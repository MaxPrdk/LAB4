using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A classA = new A(new Ford(), new Toyota(), new Nisan());
            classA.ShowTree();
            Console.ReadLine();
        }
    }
}