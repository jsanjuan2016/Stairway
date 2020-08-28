using System;

namespace Entourage.Services
{
    public interface ICustomers
    {
        string CreateNewCustomer(string name, string surname);
        string GetNameById(string id);
    }
}
