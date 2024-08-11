using ControleDeContatos.Models;
using Microsoft.EntityFrameworkCore; //etnho que pesuisar o que é o EntityFrameworkCore

namespace ControleDeContatos.Data
{
    public class BancoContext : DbContext
    { //Criar o Construtor
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
