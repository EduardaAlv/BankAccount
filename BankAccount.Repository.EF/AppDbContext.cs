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

    class Program
    {
        static void Main(string[] args)
        {
            // Criando o contexto
            using var context = new AppDbContext();

            // Criando o repositório
            var repo = new Repository<AppDbContext>(context);

            // Criando uma nova entidade
            var cliente = new Entities.BankAccount { Name = "João" };

            // Salvando a entidade através do repositório
            repo.Create(cliente);

            // Exibindo o cliente salvo
            var clienteSalvo = context.Produtos.Find(cliente.IdAccount);
            Console.WriteLine($"Cliente Salvo: {clienteSalvo.Name}");
        }
    }
}
