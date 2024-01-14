using System.ComponentModel.DataAnnotations;

namespace Connector.Models.Entities
{
    public class ProviderSummary
    {
        [Key]
        public string providerId { get; set; }
        public string providerName { get; set; }
    }
}
