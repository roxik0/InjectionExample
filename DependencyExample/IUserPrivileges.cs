using System;

namespace DependencyExample
{
    public interface IUserPrivileges
    {
        bool HasPrivileges();
    }

    public class UserPrivileges : IUserPrivileges
    {
        public bool HasPrivileges()
        {
            Console.WriteLine("Run Privileges");
            return true;
        }
    }
}