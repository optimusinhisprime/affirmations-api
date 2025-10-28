using AffirmationsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AffirmationsAPI.Data;

public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options)
        : base(options)
    {
    }

    public DbSet<Affirmation> Affirmations => Set<Affirmation>();
}
