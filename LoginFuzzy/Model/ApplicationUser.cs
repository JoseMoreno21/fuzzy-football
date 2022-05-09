using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace LoginFuzzy.Model
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Futbolista>? Futbolista { get; set; }
    }
}
