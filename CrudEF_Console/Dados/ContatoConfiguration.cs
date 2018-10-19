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
    public class ContatoConfiguration : IEntityTypeConfiguration<Contato>
    {

        public void Configure(EntityTypeBuilder<Contato> builder)
        {

            builder
                .ToTable("Contato");

            builder.HasKey(i => i.Id);

            builder.Property(i => i.Id)
                .HasColumnName("contato_id");

            builder
               .Property(a => a.tipo)
               .HasColumnName("tipo")
               .HasMaxLength(25)
               .IsRequired();

            builder
               .Property(a => a.texto)
               .HasColumnName("texto")
               .HasMaxLength(50)
               .IsRequired();

        }

    }
}
