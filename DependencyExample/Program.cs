using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using Ninject.Planning.Bindings;

namespace DependencyExample
{

    
    partial class Program
    {
        static void Main(string[] args)
        {
            IKernel nInjectContainer=new StandardKernel();
            nInjectContainer.Bind<IRepository>().To<AzureDatabase>();
            nInjectContainer.Bind<IRepository>().To<MsSqlDatabase>().WhenInjectedInto<DrugCalculator>();
            nInjectContainer.Bind<DrugCalculator>().ToSelf();
            nInjectContainer.Bind<HardwareCalculator>().ToSelf();
            nInjectContainer.Bind<DrugStore>().ToSelf();
            nInjectContainer.Bind<IUserPrivileges>().To<UserPrivileges>();





            var drugCalculator = nInjectContainer.Get<DrugCalculator>();


            Console.WriteLine("Lekarstwa:" + drugCalculator.CalculateSum());
            Console.WriteLine("Sprzęt Medyczny:" +nInjectContainer.Get<HardwareCalculator>().CalculateSum());
            Console.WriteLine("Wartość Sklepu:" + nInjectContainer.Get<DrugStore>().GetAllGoodsValue());

            Console.ReadKey();
            

        }
    }
}
