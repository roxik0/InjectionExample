using System.Collections.Generic;

namespace DependencyExample
{
    public interface IGoodRepository
    {
        IEnumerable<Good> GetGoods();
    }
}