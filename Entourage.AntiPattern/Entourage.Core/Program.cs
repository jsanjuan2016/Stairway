using Entourage.Client;
using Entourage.Domain;
using Entourage.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Entourage.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            //En algún momento necesitamos la implementación de algún componente. Siguiendo con el principio de IOC, ésta debería estar en el composition root y ser resuelta por un contenedor IOC.
            //Debemos inyectar una implementación del ICustomerFactory. 

            //Composition root. Debe conocer todos los ensamblados para poder registar todos los tipos.

            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddTransient<ICustomerRepository, CustomerRepository>()
                .AddTransient<ICustomers, Customers>()
                .AddTransient<IClientUI, ClientUI>()
                .BuildServiceProvider();


            //Client client = new Client(serviceProvider.GetService<ICustomerFactory>());
            IClientUI client = serviceProvider.GetService<IClientUI>();
            client.CreateAndShowCustomer("Javier", "Sanjuán");

            Console.ReadKey();
        }
    }
}
