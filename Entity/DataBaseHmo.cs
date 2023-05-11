using Azure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DataBaseHmo:DbContext
    {
        public DbSet<Vaccination> Vaccinations { get; set; }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<Sick> Sicks { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-459IKB2\\SQLEXPRESS;Database=Hmo;Trusted_Connection=True;Encrypt=False;");
        }
        protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {
            //// Configure relationships
            //ModelBuilder.Entity<Vaccination>()
            //    .HasOne(v => v.Friend)//זה אומר שלכל חיסון יש חבר אחד
            //    .WithMany(m => m.Vaccinations)//זה אומר שלכל חבר יש כמה חיסונים
            //    .HasForeignKey(v => v.FriendId);//וזה אומר שזה המפתח המקשר בינהם

            ModelBuilder.Entity<Vaccination>(entity =>
            {
                // Set the table name
                entity.ToTable("Vaccinations");

                // Set the primary key
                entity.HasKey(e => e.VaccineId);

                // Configure other properties
                entity.Property(e => e.DateGet).IsRequired();
               // entity.Property(e => e.).HasMaxLength(50);
                // ...
            });



            base.OnModelCreating(ModelBuilder);
        }

    }
}
