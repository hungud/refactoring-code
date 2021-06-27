using ClassLibrary1;
using Microsoft.Extensions.DependencyInjection;
using System;
using MediatR;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()                                      
                                    .AddServices()
                                    .BuildServiceProvider();

            var client = serviceProvider.GetService<IClass2>();
            client.CreateBooking();

            var mediator = serviceProvider.GetService<IMediator>();
            var pong = await mediator.Send(new ClassLibrary1.Ping.Command.Ping());
            Console.WriteLine($" mediator command response: {pong}");
            Console.ReadLine();
        }
    }
}
