using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebPiagetMvcDG.Models;

namespace WebPiagetMvcDG.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

public DbSet<WebPiagetMvcDG.Models.Aluno> Aluno { get; set; } = default!;
}
