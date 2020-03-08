using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuakeServerDomain.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuakeServerDomain.Map
{
    public class ArmasMap : IEntityTypeConfiguration<Armas>
    {

        public void Configure(EntityTypeBuilder<Armas> builder)
        {
            builder.ToTable("BS_001_ARMAS");

            builder.HasKey(k => k.Id);

            builder.Property(p => p.Id)
                .HasColumnName("ID");

            builder.Property(p => p.NomeArma)
                .HasColumnName("NOME_ARMA");

            builder.Property(p => p.Municao)
                .HasColumnName("MUNICAO_MAX");

            builder.Property(p => p.Dano)
                .HasColumnName("DANO");

        }


    }
}
