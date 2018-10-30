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
            var sum=new GoodCalculator(new Database()).CalculateSum();
            Console.WriteLine(sum);
            Console.ReadKey();

        }
    }
}
