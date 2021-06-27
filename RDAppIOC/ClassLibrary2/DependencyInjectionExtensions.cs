using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace ClassLibrary2
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddClassLib2(this IServiceCollection serviceCollection)
        {

            serviceCollection.AddTransient<IClass1, Class1>();
            serviceCollection.AddMediatR(Assembly.GetExecutingAssembly());

            return serviceCollection;
        }
    }
}
