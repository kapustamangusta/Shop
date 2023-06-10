using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rocky.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Column("full_name")]
        public string FullName { get; set; }
    }
}
