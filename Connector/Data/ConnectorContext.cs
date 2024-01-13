using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Connector.Models.Entities;

namespace Connector.Data
{
    public class ConnectorContext : DbContext
    {
        public ConnectorContext (DbContextOptions<ConnectorContext> options)
            : base(options)
        {
        }

        public DbSet<Connector.Models.Entities.Provider> Provider { get; set; } = default!;
    }
}
