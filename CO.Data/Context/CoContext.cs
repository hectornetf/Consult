using CO.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CO.Data.Context
{
    public class CoContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public CoContext(DbContextOptions options) : base(options)
        {

        }
    }
}