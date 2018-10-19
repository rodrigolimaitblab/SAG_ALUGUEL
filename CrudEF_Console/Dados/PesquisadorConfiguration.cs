using CrudEF_Console.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudEF_Console.Dados
{
    public class PesquisadorConfiguration : IEntityTypeConfiguration<Pesquisador>
    {
        public void Configure(EntityTypeBuilder<Pesquisador> builder)
        {
            builder
                .ToTable("Pesquisadores");

            builder.HasKey(p => p.Id);

            builder.Property(i => i.Id)
             .HasColumnName("pesquisador_id");

            builder
                .Property(a => a.Nome)
                .HasColumnName("nome")
                .HasMaxLength(50)
                .IsRequired();

            builder
                .HasMany(p => p.Contatos)
                .WithOne()
                .HasForeignKey("pesquisador_id");

            builder
                .HasOne(p => p.Departamento)
                .WithMany(d => d.Pesquisadores)
                .HasForeignKey("departamento_id")
                .IsRequired();

            builder
                .HasMany(p => p.Artigos)
                .WithOne(a => a.Pesquisador)
                .HasForeignKey("pesquisador_id")
                .IsRequired();

        }
    }
}
