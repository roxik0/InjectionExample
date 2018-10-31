using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using Ninject.Planning.Bindings;

namespace DependencyExample
{

    public class NiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository>().To<MsSqlDatabase>().WhenInjectedInto<DrugCalculator>();
            Bind<DrugCalculator>().ToSelf();
            Bind<IRepository>().To<AzureDatabase>();

        }
    }

    public class MyClass : Attribute
    {
     }
    
    partial class Program
    {
        static void Main(string[] args)
        {
            IKernel myApp=new StandardKernel(new NiceModule());

            var drugCalculator = myApp.Get<DrugCalculator>();
            Console.WriteLine("Lekarstwa:" + drugCalculator.CalculateSum());
            Console.WriteLine("Sprzęt Medyczny:" + new HardwareCalculator(myApp.Get<IRepository>()).CalculateSum());
            Console.WriteLine("Wartość Sklepu:" + new DrugStore(myApp.Get<IRepository>()).GetAllGoodsValue());

            Console.ReadKey();
            

        }
    }

  
}
