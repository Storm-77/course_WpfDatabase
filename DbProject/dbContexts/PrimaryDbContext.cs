using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using DbProject.dtos;

namespace DbProject.dbContexts
{
    class PrimaryDbContext : DbContext
    {
        public PrimaryDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
            this.Model.GetEntityTypes();   
        }

        public DbSet<ExampleDTO> kids { get; set; }
    }
}
