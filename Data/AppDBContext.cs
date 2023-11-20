using Microsoft.EntityFrameworkCore;
using Phone_App.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_App
{
    public class AppDBContext : DbContext
    {
        public DbSet<ContactsEntity> Contacts { get; set; }

        private string DbPath { get; set; }
        public AppDBContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "bookcontact.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactsEntity>().HasData(
            new ContactsEntity() {
                ID = 1,
                Name = "someone",
                Number = "234528690",
                Email = "someone@gmail.com",
                Address = "Some address" },

            new ContactsEntity()
            {
                ID = 2,
                Name = "someone2",
                Number = "949291345"
            }
            );
        }
    }
}
