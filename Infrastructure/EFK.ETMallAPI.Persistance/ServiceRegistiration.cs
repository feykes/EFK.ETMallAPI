using Microsoft.EntityFrameworkCore;
using EFK.ETMallAPI.Persistance.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFK.ETMallAPI.Application.Repositories;
using EFK.ETMallAPI.Persistance.Repositories;

namespace EFK.ETMallAPI.Persistance
{
    public static class ServiceRegistiration
    {
        public static void AddPersistenceService(this IServiceCollection services) //buradan program.csye erişiyoruz
        {
            services.AddDbContext<ETMallAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>(); //context scoped lifetime olduğu için 
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
        }
    }
}
