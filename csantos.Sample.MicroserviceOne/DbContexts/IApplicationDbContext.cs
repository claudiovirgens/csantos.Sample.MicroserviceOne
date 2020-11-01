using Microsoft.EntityFrameworkCore;
using csantos.Sample.MicroserviceOne.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csantos.Sample.MicroserviceOne.DbContexts
{
    public interface IApplicationDbContext
    {
        DbSet<Order> Orders { get; set; }
        Task<int> SaveChanges();
    }
}
