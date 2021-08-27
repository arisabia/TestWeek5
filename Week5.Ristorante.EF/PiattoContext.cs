using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Week5.Ristorante.Core.Models;

namespace Week5.Ristorante.EF
{
    public class PiattoContext : DbContext
    {
        public DbSet<Piatto> Piatti { get; set; }
        public DbSet<Account> Accounts { get; set; }

        public PiattoContext(DbContextOptions<PiattoContext> options) : base(options) { }
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Piatto>().ToTable("Piatto")
                                        .HasKey(k => k.Id);
            modelBuilder.Entity<Piatto>().Property(n => n.Nome)
                                        .HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Piatto>().Property(n => n.Descrizione)
                                      .IsRequired();
            modelBuilder.Entity<Piatto>().Property(n => n.Tipo)
                                      .IsRequired();
            modelBuilder.Entity<Piatto>().Property(n => n.Prezzo)
                                      .IsRequired().HasColumnType("decimal");

            modelBuilder.Entity<Account>().ToTable("Users")
                                           .HasKey(k => k.Id);
            modelBuilder.Entity<Account>().Property(p => p.Username)
                                           .IsRequired();
            modelBuilder.Entity<Account>().Property(p => p.Password)
                                          .IsRequired();
            modelBuilder.Entity<Account>().Property(p => p.Role)
                                          .IsRequired();
            modelBuilder.Entity<Account>().HasData(
               new Account
               {
                   Id = 1,
                   Username = "manager@piattini.it",
                   Password = "1234",
                   Role = Role.Ristoratore
               },
               new Account
               {
                   Id = 2,
                   Username = "larisa@abc.it",
                   Password = "1234",
                   Role = Role.Cliente
               }
           );
        }
    
    }
}
