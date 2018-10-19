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
    public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
    {

        public void Configure(EntityTypeBuilder<Departamento> builder)
        {


            builder
           .ToTable("Departamento");

            builder.HasKey(d => d.Id);

            builder.Property(i => i.Id)
              .HasColumnName("departamento_id");

            // Descricao string
            builder
               .Property(a => a.Descricao)
               .HasColumnName("descricao")
                .HasMaxLength(50)
               .IsRequired();


        }

    }
}
