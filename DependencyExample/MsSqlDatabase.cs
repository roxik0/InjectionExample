using System;
using System.Collections.Generic;
using System.Threading;

namespace DependencyExample
{
    public class MsSqlDatabase:IRepository
    {
        public MsSqlDatabase()
        {
              Console.WriteLine("Run");
        }
        public IEnumerable<Good> GetDrugs()
        {
            
            return new List<Good>()
            {
                new Good(){ Name="Mefedron", Price= 56},
                new Good(){ Name="Oxylon", Price= 200},
                new Good(){ Name="Flakka", Price= 30},
            };
        }

        public IEnumerable<Good> GetHardware()
        {
            return new List<Good>()
            {
                new Good(){ Name="Strzykawka", Price= 1},
                new Good(){ Name="Wata", Price= 1},
                new Good(){ Name="Igła", Price= 1},
            };
        }
    }
}
