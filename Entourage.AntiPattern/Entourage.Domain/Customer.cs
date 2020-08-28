using System;
using System.Collections.Generic;
using System.Text;

namespace Entourage.Domain
{
    public class Customer : ICustomer
    {
        private readonly Guid _Id;
        private readonly string _name;
        private readonly string _surname;

        public Customer(string name, string surname)
        {
            _Id = Guid.NewGuid();
            _name = name;
            _surname = surname;
        }
        public string GetId()
        {
            return _Id.ToString();
        }
        public string GetFullName()
        {
            return $"{_name} {_surname}";
        }
    }
}
