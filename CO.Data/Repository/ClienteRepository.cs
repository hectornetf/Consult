using CO.Core.Domain;
using CO.Data.Context;
using CO.Manager.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO.Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly CoContext context;

        public ClienteRepository(CoContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Cliente>> GetClientesAsync()
        {
            return await context.Clientes.AsNoTracking().ToListAsync();
        }

        public async Task<Cliente> GetClienteAsync(int id)
        {
            return await context.Clientes.FindAsync(id);
        }
    }
}
