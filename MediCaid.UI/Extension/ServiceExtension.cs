using MediCaid.Implementation;
using MediCaid.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediCaid.UI.Extension
{
    public static class ServiceExtension
    {
        public static void Extensions(this IServiceCollection service)
        {
            service.AddTransient(typeof(IGenericRepository<,>), typeof(GenericImplementation<,>));
        }
    }
}
