using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.EntityFrameworkCore.Extensions;
using MySql;
using MySql.EntityFrameworkCore.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DbProject.dbContexts
{
    class DbContextFactory
    {
        private readonly string m_connectionString;

        public DbContextFactory(string connectionString)
        {
            m_connectionString = connectionString;
        }

        public PrimaryDbContext CreateDbContext()
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseMySQL(m_connectionString).Options;
            return new PrimaryDbContext(options);
        }
    }
}
