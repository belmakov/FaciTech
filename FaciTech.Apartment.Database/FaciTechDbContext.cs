﻿using FaciTech.Apartment.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace FaciTech.Apartment.Database
{
    public class FaciTechDbContext : DbContext
    {

        public FaciTechDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Community> Community { get; set; }
        public DbSet<Block> Block { get; set; }
        public DbSet<CommunityLocation> CommunityLocation { get; set; }
        public DbSet<Country> Country{ get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Area> Area { get; set; }
        public DbSet<SubArea> SubArea { get; set; }
        public DbSet<Amenity> Amenity { get; set; }
        public DbSet<Unit> Unit { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>(e=>e.ToTable("User"));
        }
    }
}
