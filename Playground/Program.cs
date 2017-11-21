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
            SelfDividingNumbers self = new SelfDividingNumbers();
            Console.WriteLine(string.Join( ", ", self.isSelfDividing(1, 22).ToArray()));
            Console.ReadKey();

            

        }

        
    }
}
