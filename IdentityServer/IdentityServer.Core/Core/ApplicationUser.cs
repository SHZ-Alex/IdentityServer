using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace IdentityServer.Core.Core;

public class ApplicationUser : IdentityUser
{
    [Required]
    public string Name { get; set; }
}