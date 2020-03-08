using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuakeServerDomain.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuakeServerDomain.Map
{
    public class MortesMap : IEntityTypeConfiguration<Mortes>
    {
        public void Configure(EntityTypeBuilder<Mortes> builder)
        {
            builder.ToTable("BS_005_MORTES");

            builder.HasKey(k => k.Id);

            builder.Property(p => p.Id)
                .HasColumnName("ID");

            builder.Property(p => p.IdClienteMatou)
                .HasColumnName("ID_CLIENTE_MATOU");

            builder.Property(p => p.Cliente_Matou)
                .HasColumnName("CLIENTE_MATOU");
            
            builder.Property(p => p.IdArma)
                .HasColumnName("ID_ARMA");

            builder.Property(p => p.Quantidade)
                .HasColumnName("QUANTIDADE");

            builder.Property(p => p.IdClienteMorto)
                .HasColumnName("ID_CLIENTE_MORTO");

            builder.Property(p => p.Cliente_Morto)
                .HasColumnName("CLIENTE_MORTO");

            builder.Property(p => p.IdPartida)
                .HasColumnName("ID_PARTIDA");


        }

    }
}
