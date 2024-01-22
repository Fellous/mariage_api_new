using mariage_api_new.Models;
using Microsoft.EntityFrameworkCore;

namespace mariage_api_new.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Invite> Invites { get; set; }
    public DbSet<Mariage> Mariages { get; set; }
    // Définissez un DbSet pour chaque modèle/table.
}