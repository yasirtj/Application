using Application.Student;
using Infrastructure.Students;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.ServiceExtention
{
   public static class InfrastructureServices
    {
        public static void InfrastructureService(this IServiceCollection services)
        {
            services.AddScoped<IStudentRepositorycs, StudentRepository>();

        }
    }
}
