using Entourage.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entourage.Services
{
    public class Customers : ICustomers
    {
        private readonly ICustomerRepository _customerRepository;
        public Customers(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public string CreateNewCustomer(string name, string surname)
        {
            return _customerRepository.CreateNewCustomer(name, surname);
        }
        public string GetNameById(string id)
        {
            return _customerRepository.GetFullNameByCustomerId(id);
        }
    }
}
