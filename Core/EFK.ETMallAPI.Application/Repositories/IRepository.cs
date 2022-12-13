using EFK.ETMallAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFK.ETMallAPI.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity //constraint
    {
        DbSet<T> Table { get; }
    }
}
