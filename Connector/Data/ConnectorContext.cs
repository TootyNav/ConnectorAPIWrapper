
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

        public DbSet<Provider> Provider { get; set; } = default!;
        public DbSet<ProviderSummary> ProviderSummary { get; set; } = default!;
    }
}
