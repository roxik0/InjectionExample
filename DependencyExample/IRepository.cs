using System.Collections.Generic;

namespace DependencyExample
{
    public interface IRepository
    {
        IEnumerable<Good> GetDrugs();
        IEnumerable<Good> GetHardware();
    }
}