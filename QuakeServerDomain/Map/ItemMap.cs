using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuakeServerDomain.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuakeServerDomain.Map
{
    public class ItemMap : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {

            builder.ToTable("BS_003_ITEM");

            builder.HasKey(k => k.Id);

            builder.Property(p => p.Id)
                .HasColumnName("ID");

            builder.Property(p => p.Nome)
                .HasColumnName("NOME");

            builder.Property(p => p.Escudo)
                .HasColumnName("ESCUDO");

            builder.Property(p => p.Vida)
                .HasColumnName("VIDA");

        }

    }
}
