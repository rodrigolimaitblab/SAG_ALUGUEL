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
    public class IdiomaConfiguration : IEntityTypeConfiguration<Idioma>
    {

        public void Configure(EntityTypeBuilder<Idioma> builder)
        {

            builder
               .ToTable("tbl_Idioma");

            builder.HasKey(i => i.Id);

            builder.Property(i => i.Id)
                .HasColumnName("idioma_id");
                
            builder
           .Property(a => a.Descricao)
           .HasColumnName("descricao")
           .HasMaxLength(50)
           .IsRequired();

        }

    }
}
