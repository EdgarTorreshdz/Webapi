using Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
  public class ApiDbContext : IdentityDbContext
  {
    public DbSet<FootballTeam> Teams { get; set; }
    //creando contexto de base de datos con entity framework
    public ApiDbContext(DbContextOptions<ApiDbContext> options): base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Ignore<Entity>();
      base.OnModelCreating(modelBuilder);
    }
  }
}
