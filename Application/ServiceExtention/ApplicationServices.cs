using Application.Student.Commands;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ServiceExtention
{
    public static class ServiceCollectionExtensions
    {
        public static void ApplicationService(this IServiceCollection services)
        {
            services.AddTransient<ICreateStudent, CreateStudent>();

        }
    }
}
