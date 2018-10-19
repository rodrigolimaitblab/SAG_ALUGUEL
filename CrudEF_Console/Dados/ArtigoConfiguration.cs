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
    public class ArtigoConfiguration : IEntityTypeConfiguration<Artigo>
    {

        public void Configure(EntityTypeBuilder<Artigo> builder)
        {

            builder
               .ToTable("Artigo");

            builder.HasKey(i => i.Id);

            builder.Property(i => i.Id)
                .HasColumnName("artigo_id");

            builder
                .Property(a => a.dataPublicacao)
                .HasColumnName("datapublicacao")
                .HasColumnType("datetime");

            builder
               .Property(a => a.ISBN)
               .HasColumnName("ISBN")
               .HasMaxLength(10)
               .IsRequired();

            builder
                .HasOne(a => a.idiomaOriginal)
                .WithMany(i => i.ArtigoOriginal)
                .HasForeignKey("idioma_original")
                .IsRequired();

            builder
               .HasOne(a => a.idiomaTraduzido)
               .WithMany(i => i.ArtigoTraduzido)
               .HasForeignKey("idioma_traduzido");

            builder
               .Property(a => a.titulo)
               .HasColumnName("titulo")
               .HasMaxLength(50)
               .IsRequired();

            builder
             .Property(a => a.ano)
             .HasColumnName("ano")
             .HasColumnType("int")
             .IsRequired();

        }


    }
}
