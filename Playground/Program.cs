using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class Program
    {
        
        static void Main(string[] args)
        {
            NextGreaterElement nge = new NextGreaterElement();
            Console.WriteLine(string.Join( ", ", nge.nge(new int[]{4, 1, 2}, new int[]{1, 3, 4, 2})));
            Console.ReadKey();

            

        }

        
    }
}
