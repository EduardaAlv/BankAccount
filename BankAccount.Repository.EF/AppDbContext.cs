using Microsoft.EntityFrameworkCore;

namespace BankAccount.Repository.EF
{
    public class AppDbContext : DbContext
    {
        //mapeamento da entidade para a tabela
        public DbSet<Entities.BankAccount> Produtos { get; set; }

        //o provedor e a string de conexão
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-ILHUQ20;Initial Catalog=teste;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
