using Microsoft.EntityFrameworkCore;
using SportStyle.Domain.Entities;

namespace Olimpiadas.Infrastructure.Persistence;

public class OlimpiadasDbContext : DbContext
{
    public OlimpiadasDbContext(DbContextOptions<OlimpiadasDbContext> options) : base(options) { }

    public DbSet<Cliente> Clientes { get; set; }


    // ejemplo: public DbSet<Nombre de la clase> Nombre_De_La_Clase { get; set; }
    //  public DbSet<Cliente> Clientes { get; set ;}
}

// dotnet ef migrations add FirstMigration --context UserApiDBContext --project .\UserApi.Infrastructure\ --startup-project .\UserApi.Presentation\


// dotnet ef database update --context UserApiDBContext --project .\UserApi.Infrastructure\ --startup-project .\UserApi.Presentation\