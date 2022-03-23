using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject.dbContexts
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<PrimaryDbContext>
    {
        PrimaryDbContext IDesignTimeDbContextFactory<PrimaryDbContext>.CreateDbContext(string[] args)
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseMySQL("server=localhost;user=root;database=test;password=;port=3306").Options;
            return new PrimaryDbContext(options);

        }
    }
}
