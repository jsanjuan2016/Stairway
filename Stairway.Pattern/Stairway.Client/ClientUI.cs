using Stairway.ClientInterfaces;
using Stairway.ServicesInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stairway.Client
{
    public class ClientUI : IClientUI
    {
        private readonly ICustomers _service;
        public ClientUI(ICustomers service)
        {
            _service = service;
        }
        public void CreateAndShowCustomer(string name, string surname)
        {
            string id = _service.CreateNewCustomer(name, surname);
            string fullName = _service.GetNameById(id);

            Console.WriteLine($"Customer found: {fullName}");
        }
    }
}
