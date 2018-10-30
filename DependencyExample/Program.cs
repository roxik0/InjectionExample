using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            new GoodCalculator().Calculate();
            Console.ReadKey();

        }
    }
}
