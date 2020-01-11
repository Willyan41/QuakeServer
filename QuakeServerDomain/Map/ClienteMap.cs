using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuakeServerDomain.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuakeServerDomain.Map
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("BS_001_CLIENTE");

            builder.HasKey(k => k.Id);

            builder.Property(p => p.Id)
                .HasColumnName("ID");

            builder.Property(p => p.IdPosicao)
                .HasColumnName("ID_POSICAO");

            builder.Property(p => p.NickName)
                .HasColumnName("NICKNAME");

            builder.Property(p => p.Personagem)
                .HasColumnName("PERSONAGEM");

            builder.Property(p => p.Personagem_Alterado)
                .HasColumnName("PERSONAGEM_ALTERADO");

            builder.Property(p => p.Vida)
                .HasColumnName("VIDA");

            builder.Property(p => p.Escudo)
                .HasColumnName("ESCUDO");

            builder.Property(p => p.Matou)
                .HasColumnName("MATOU");

            builder.Property(p => p.Morreu)
                .HasColumnName("MORREU");


        }

    }
}
