using System;

namespace Entourage.Domain
{
    public interface ICustomerRepository
    {
        string CreateNewCustomer(string name, string surname);
        string GetFullNameByCustomerId(string id);
    }
}
