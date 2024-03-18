using IdentityServer.Core.Core;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityServer.Data.Data;

public class ApplicationDbContext(DbContextOptions options) : IdentityDbContext(options)
{
    public DbSet<ApplicationUser> ApplicationUser { get; set; } = null!;
}