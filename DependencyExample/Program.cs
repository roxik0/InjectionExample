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
#if DEBUG
            ApplicationDependency.CurrentRepository = new MsSqlDatabase();
#else
           ApplicationDependency.CurrentRepository = new AzureDatabase();
#endif



            Console.WriteLine("Lekarstwa:" + new DrugCalculator(ApplicationDependency.CurrentRepository).CalculateSum());
            Console.WriteLine("Sprzęt Medyczny:" + new HardwareCalculator(ApplicationDependency.CurrentRepository).CalculateSum());
            Console.WriteLine("Wartość Sklepu:" + new DrugStore().GetAllGoodsValue());

            Console.ReadKey();
            

        }
    }

    public static class ApplicationDependency
    {
        public static IRepository CurrentRepository;
    }
}
