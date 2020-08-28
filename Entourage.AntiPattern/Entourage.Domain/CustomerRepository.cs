using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entourage.Domain
{
    public class CustomerRepository : ICustomerRepository
    {
        private ICollection<ICustomer> _customers = new HashSet<ICustomer>();
        public CustomerRepository()
        {
        }

        public string CreateNewCustomer(string name, string surname)
        {
            ICustomer customer = new Customer(name, surname);
            _customers.Add(customer);

            Console.WriteLine($"Customer created: {customer.GetFullName()}");

            return customer.GetId();
        }
        public string GetFullNameByCustomerId(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentNullException();
            }

            ICustomer customer = _customers.FirstOrDefault(m => m.GetId() == id);

            if (customer == null)
            {
                throw new ArgumentException();
            }

            return customer.GetFullName();
        }
    }
}
