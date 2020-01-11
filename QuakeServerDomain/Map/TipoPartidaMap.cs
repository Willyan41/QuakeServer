using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuakeServerDomain.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuakeServerDomain.Map
{
    public class TipoPartidaMap : IEntityTypeConfiguration<TipoPartida>
    {
        public void Configure(EntityTypeBuilder<TipoPartida> builder)
        {

            builder.ToTable("BS_005_TIPO_PARTIDA");

            builder.HasKey(k => k.Id);

            builder.Property(p => p.Id)
                .HasColumnName("ID");

            builder.Property(p => p.Tipo)
                .HasColumnName("TIPO");


        }

    }
}
