using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_TSP_NET
{
    public class Optiune
    {
        public delegate int Operation(int a, int b);
        public event Operation operation;
        public void Afisare(int a ,int b)
        {
            Console.WriteLine(operation(a,b));
        }
    }
}
