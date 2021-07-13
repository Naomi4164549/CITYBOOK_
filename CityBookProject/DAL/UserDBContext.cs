using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
   public class UserDBContext:DbContext
    {
        public UserDBContext()
        {
        }

        public UserDBContext(DbContextOptions <UserDBContext> options) : base(options)
        {

        }
        public DbSet<UserEntity> User { get; set; }
        public DbSet<ChildEntity> Child { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=city_book_test1;Integrated Security=True");

            }
            optionsBuilder.ReplaceService<IMigrationsSqlGenerator, SqlServerMigrationsSqlGenerator>();
        }
    }
}
