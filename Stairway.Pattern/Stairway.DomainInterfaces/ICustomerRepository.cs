using System;

namespace Stairway.DomainInterfaces
{
    public interface ICustomerRepository
    {
        string CreateNewCustomer(string name, string surname);
        string GetFullNameByCustomerId(string id);
    }
}
