using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyExample
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lekarstwa:" + new DrugCalculator(new Database()).CalculateSum());
            Console.WriteLine("Sprzęt Medyczny:" + new HardwareCalculator(new Database()).CalculateSum());
            Console.WriteLine("Wartość Sklepu:" + new DrugStore().GetAllGoodsValue());

            Console.ReadKey();
            

        }
    }
}
