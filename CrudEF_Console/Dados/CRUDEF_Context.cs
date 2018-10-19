using System;
using CrudEF_Console.Negocio;
using Microsoft.EntityFrameworkCore;


namespace CrudEF_Console.Dados
{
    public class CRUDEF_Context: DbContext
    {

        public DbSet<Artigo> Artigos { get; set; }
        //public DbSet<Contato> Contatos { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Idioma> Idiomas { get; set; }
        public DbSet<Pesquisador> Pesquisadores { get; set; }
        public DbSet<Veiculo_Publicacao> VeiculoPublicacoes { get; set; }
        
        public CRUDEF_Context()
        {

            

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
      
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=CRUDEF_Console;Trusted_connection=true;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new ArtigoConfiguration());
            //modelBuilder.ApplyConfiguration(new ContatoConfiguration());
            modelBuilder.ApplyConfiguration(new DepartamentoConfiguration());
            modelBuilder.ApplyConfiguration(new IdiomaConfiguration());
            modelBuilder.ApplyConfiguration(new PesquisadorConfiguration());
            modelBuilder.ApplyConfiguration(new Veiculo_PublicacaoConfiguration());


        }






    }
}
