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
    public class Veiculo_PublicacaoConfiguration : IEntityTypeConfiguration<Veiculo_Publicacao>
    {

        public void Configure(EntityTypeBuilder<Veiculo_Publicacao> builder)
        {

            builder
               .ToTable("tbl_Veiculo_Publicacao");

            // Id
            //builder.Property(i => i.Id)
            // .HasColumnName("veiculo_publicacao_id")
            //  .HasColumnType("tinyint");

            builder
                .HasKey(vp => vp.Id);

            // tipo string
            builder
              .Property(a => a.tipo)
              .HasColumnName("tipo")
              .HasColumnType("varchar(25)")
              .IsRequired();

            // descricao string
            builder
              .Property(a => a.descricao)
              .HasColumnName("descricao")
              .HasColumnType("varchar(50)")
              .IsRequired();

            // dataPublicacao datetime
            //builder
            //    .Property(a => a.dataPublicacao)
            //    .HasColumnName("datapublicacao")
            //    .HasColumnType("datetime");

            //Relacionamento com Artigo
            builder
                .HasMany(a => a.artigo)
                .WithOne(vp => vp.veiculo_publicacao)
                .HasForeignKey("veiculo_publicacao_id");

        }

    }
}
