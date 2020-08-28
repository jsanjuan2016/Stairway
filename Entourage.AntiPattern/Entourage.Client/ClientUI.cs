using Entourage.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entourage.Client
{
    public class ClientUI : IClientUI
    {
        private readonly ICustomers _service;
        public ClientUI(ICustomers service)
        {
            _service = service;

            //Sin utilizar diferentes ensamblados para las interfaces, un programador "despistadop" podría escribir la siguiente linea de código sin problema. Saltándose la inyección de la dependencia.
            _service = new Services.Customers(new Domain.CustomerRepository()); 
        }
        public void CreateAndShowCustomer(string name, string surname)
        {
            string id = _service.CreateNewCustomer(name, surname);
            string fullName = _service.GetNameById(id);

            Console.WriteLine($"Customer found: {fullName}");
        }
    }
}
