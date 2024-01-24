using Microsoft.EntityFrameworkCore;
using MinyanApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinyanApp.Data
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Synagogue> Synagogues { get; set; }

        public DbSet<Minyan> Minyans { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;DataBase=minyan_db");
        }


        //public DataContext() {
        //    Users = new List<User>();
        //    User one = new User() { Key = 1, FName = "yakov", LName = "sagron", Email = "b3212525@gmail.com" };
        //    Users.Add(one);
        //}
    }
}
