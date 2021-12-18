using System.ComponentModel.DataAnnotations;

namespace GQLWebApi.Models
{
    public class Platform
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public string? LicenseKey { get; set; }

    }
}
