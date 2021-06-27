using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace ClassLibrary1
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection serviceCollection)
        {

            serviceCollection.AddTransient<IClass1, Class1N>();
            serviceCollection.AddTransient<IClass2, Class2>();
            serviceCollection.AddTransient<IClass3, Class3>();
            serviceCollection.AddMediatR(Assembly.GetExecutingAssembly());

            return serviceCollection;
        }
    }
}
