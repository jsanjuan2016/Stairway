using System;

namespace Stairway.ServicesInterfaces
{
    public interface ICustomers
    {
        string CreateNewCustomer(string name, string surname);
        string GetNameById(string id);
    }
}
