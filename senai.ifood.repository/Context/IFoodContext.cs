using Microsoft.EntityFrameworkCore;
using senai.ifood.domain.Entities;

namespace senai.ifood.repository.Context
{
/*para usar DBContext, precisa baixar no nuget Microsoft.EntityFrameworkCore, 
Microsoft.EntityFrameworkCore.Relational e Microsoft.EntityFrameworkCore.SqlServer
e acrescentar no csproj:
e referenciar o projeto domain*/
    public class IFoodContext: DbContext
    {
        public IFoodContext(DbContextOptions<IFoodContext> options):base (options){

        }

        public DbSet<UsuarioDomain> Usuarios { get; set; }

        public DbSet<ClienteDomain> Clientes { get; set; }
        public DbSet<EspecialidadeDomain> Especialidades { get; set; }
        public DbSet<PermissaoDomain> Permissoes { get; set; }
        public DbSet<ProdutoRestauranteDomain> ProdutosRestaurantes { get; set; }
        public DbSet<RestauranteDomain> Restaurantes { get; set; }
        public DbSet<UsuarioPermissaoDomain> UsuariosPermissoes { get; set; }

        //baseDomain não precisa de DbSet, pois é abstract       

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<UsuarioDomain>().ToTable("Usuarios");
            modelBuilder.Entity<ClienteDomain>().ToTable("Clientes");
            modelBuilder.Entity<EspecialidadeDomain>().ToTable("Especialidades");
            modelBuilder.Entity<PermissaoDomain>().ToTable("Permissoes");
            modelBuilder.Entity<ProdutoRestauranteDomain>().ToTable("ProdutosRestaurantes");
            modelBuilder.Entity<RestauranteDomain>().ToTable("Restaurantes");
            modelBuilder.Entity<UsuarioPermissaoDomain>().ToTable("UsuariosPermissoes");

        } 

        /*
Precisa adicionar os csprojs na solution para o intellesense funcionar:
_____________
dotnet sln add "Senai.Ifood.Domain/Senai.Ifood.Domain.csproj";
dotnet sln add "Senai.Ifood.Repository/Senai.Ifood.Repository.csproj";
dotnet sln add "Senai.Ifood.WebApi/Senai.Ifood.WebApi.csproj"
_____________
 */
    }
}