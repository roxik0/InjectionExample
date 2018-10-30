using System.Collections.Generic;

namespace DependencyExample
{
    public class Database:IRepository
    {
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
