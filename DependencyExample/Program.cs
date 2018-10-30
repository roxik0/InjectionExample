using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace DependencyExample
{
    partial class Program
    {
        static void Main(string[] args)
        {
            IKernel myApp=new StandardKernel();
            myApp.Bind<IRepository>().To<MsSqlDatabase>().InSingletonScope();
            IKernel myAzure = new StandardKernel();
            myAzure.Bind<IRepository>().To<AzureDatabase>();


            Console.WriteLine("Lekarstwa:" + new DrugCalculator(myApp.Get<IRepository>()).CalculateSum());
            Console.WriteLine("Sprzęt Medyczny:" + new HardwareCalculator(myAzure.Get<IRepository>()).CalculateSum());
            Console.WriteLine("Wartość Sklepu:" + new DrugStore(myApp.Get<IRepository>()).GetAllGoodsValue());

            Console.ReadKey();
            

        }
    }

  
}
