using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuakeServerDomain.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuakeServerDomain.Map
{
    public class PartidaMap : IEntityTypeConfiguration<Partida>
    {

        public void Configure(EntityTypeBuilder<Partida> builder)
        {

            builder.ToTable("BS_004_PARTIDA");

            builder.HasKey(k => k.Id);

            builder.Property(p => p.Id)
                .HasColumnName("ID_PARTIDA");

            builder.Property(p => p.Tipo)
                .HasColumnName("TIPO");

            builder.Property(p => p.NMaxJogadores)
                .HasColumnName("N_MAX_JOGADORES");

            builder.Property(p => p.Cliente)
                .HasColumnName("CLIENTE");

            builder.Property(p => p.TotalMortes)
                .HasColumnName("TOTAL_MORTES");

            builder.Property(p => p.ScoreCliente)
                .HasColumnName("SCORE_CLIENTE");

        }

    }
}
