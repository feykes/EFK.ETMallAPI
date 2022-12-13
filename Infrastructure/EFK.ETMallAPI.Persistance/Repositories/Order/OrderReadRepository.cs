using EFK.ETMallAPI.Application.Repositories;
using EFK.ETMallAPI.Domain.Entities;
using EFK.ETMallAPI.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFK.ETMallAPI.Persistance.Repositories
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(ETMallAPIDbContext context) : base(context)
        {
        }
    }
}
 