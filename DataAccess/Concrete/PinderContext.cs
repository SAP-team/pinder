﻿using Core.Entities.Concrete;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class PinderContext:DbContext
    {
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = 93.89.238.98; Database = orhanardaduman_; user = orhanardaduman; password = '_yd3Qn11'; ",
                    builder => builder.EnableRetryOnFailure());
            }

            //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Pinder;Trusted_Connection=true");
        }
    
        public DbSet<Post> Post { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        //"Server=93.89.238.98;Database=orhanardaduman_;user=orhanardaduman;password='_yd3Qn11';"
    }
}
