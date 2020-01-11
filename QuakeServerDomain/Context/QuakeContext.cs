using Microsoft.EntityFrameworkCore;
using QuakeServerDomain.Entidade;
using QuakeServerDomain.Map;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuakeServerDomain.Context
{
    public class QuakeContext : DbContext
    {
        public DbSet<Arma> Arma { get; set; }
        public DbSet<Armas> Armas { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Mortes> Mortes { get; set; }
        public DbSet<Partida> Partida { get; set; }
        public DbSet<TipoPartida> TipoPartida { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArmaMap());
            modelBuilder.ApplyConfiguration(new ArmasMap());
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new ItemMap());
            modelBuilder.ApplyConfiguration(new MortesMap());
            modelBuilder.ApplyConfiguration(new PartidaMap());
            modelBuilder.ApplyConfiguration(new TipoPartidaMap());
        }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=BOMBINHA;Initial Catalog=QUAKESERVER;Integrated Security=True");
        }



    }
}
