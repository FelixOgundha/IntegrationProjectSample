using IntegrationProjectSample.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace IntegrationProjectSample.DataAccess.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Employee> Employees { get; set; }
    }
    }
