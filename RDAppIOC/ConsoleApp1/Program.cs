using ClassLibrary1;
using ClassLibrary2;
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
                                    .AddClassLib1()
                                    .AddClassLib2()
                                    .BuildServiceProvider();

            var client1 = serviceProvider.GetService<IClass2>();
            client1.CreateBooking();

            var client2 = serviceProvider.GetService<ClassLibrary2.IClass1>();
            client2.Hello();

            var mediator = serviceProvider.GetService<IMediator>();
            var pong = await mediator.Send(new ClassLibrary1.Ping.Command.Ping());
            Console.WriteLine($" mediator command response: {pong}");
            Console.ReadLine();
        }
    }
}
