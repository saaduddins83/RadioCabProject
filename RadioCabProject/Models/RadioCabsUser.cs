using Microsoft.AspNetCore.Identity;

namespace RadioCabProject.Models
{
    public class RadioCabsUser : IdentityUser
    {
        public string? FullName { get; set; }
    }
}
