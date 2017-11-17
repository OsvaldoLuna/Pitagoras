using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitagoras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Para el teorema de pitagoras se necesita:");
            Console.WriteLine("Medida del cateto opuesto:");
            int co = int.Parse(Console.ReadLine());
            Console.WriteLine("Medida del cateto adyacente:");
            int ca = int.Parse(Console.ReadLine());
            Console.WriteLine(" |\" ");
            Console.WriteLine(" | \" ");
            Console.WriteLine(" |  \" ");
            Console.WriteLine(" |___\" ");
            Console.WriteLine("El teorema es: {0}"+ co*ca);
            Console.ReadKey();
        }
    }
}
