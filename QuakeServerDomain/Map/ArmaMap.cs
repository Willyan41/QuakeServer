using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuakeServerDomain.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuakeServerDomain.Map
{
    public class ArmaMap : IEntityTypeConfiguration<Arma>
    {
        public void Configure(EntityTypeBuilder<Arma> builder)
        {
            builder.ToTable("BS_007_ARMA");

            builder.HasKey(k => k.Id);

            builder.Property(p => p.Id)
                .HasColumnName("ID");

            builder.Property(p => p.IdCliente)
                .HasColumnName("ID_CLIENTE");

            builder.Property(p => p.IdArma1)
                .HasColumnName("ID_ARMA1");

            builder.Property(p => p.IdArma2)
                .HasColumnName("ID_ARMA2");

            builder.Property(p => p.IdArma3)
              .HasColumnName("ID_ARMA3");


        }


    }
}
