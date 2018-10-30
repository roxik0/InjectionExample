using System.Collections.Generic;

namespace DependencyExample
{
    public class Database:IGoodRepository
    {
        public IEnumerable<Good> GetGoods()
        {
            return new List<Good>()
            {
                new Good(){ Name="DB_Mefedron", Price= 56},
                new Good(){ Name="DB_Oxylon", Price= 200},
                new Good(){ Name="DB_Flakka", Price= 30},
            };
        }
    }
}
