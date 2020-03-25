using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_TSP_NET
{
    public class Program
    {
        static void Main(string[] args)
        {
            Optiune item = new Optiune();
            item.operation += (a, b) => a + b;
            item.Afisare(5, 3);
            Console.WriteLine(PrimNumber(70));
        }

        public static int PrimNumber(int a)
        {
            for (int i = a-1; i > 0; i--)
            {
                int numarPrim = 0;              
                for (int j=2; j <= i / 2; j++)
                    {
                    if (i % j == 0)
                    {
                            numarPrim ++;
                    }
                    if (numarPrim == 0)
                    {
                        return i;
                    }
                }  
            }
            return 0;
        }
    }
}
