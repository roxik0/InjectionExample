using System.Collections.Generic;

namespace DependencyExample
{
    public class AzureDatabase : IRepository
    {
        public IEnumerable<Good> GetDrugs()
        {
            return new List<Good>()
            {
                new Good(){ Name="Mefedron", Price= 560},
                new Good(){ Name="Oxylon", Price= 2000},
                new Good(){ Name="Flakka", Price= 300},
                new Good(){ Name="Lsd", Price= 50},
            };
        }

        public IEnumerable<Good> GetHardware()
        {
            return new List<Good>()
            {
                new Good(){ Name="Strzykawka", Price= 10},
                new Good(){ Name="Wata", Price= 10},
                new Good(){ Name="Igła", Price= 10},
            };
        }

    }
}