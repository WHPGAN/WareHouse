﻿using Microsoft.EntityFrameworkCore;
using WareHouse.Core.Helper;
using WareHouse.Entity;

namespace WareHouse.Core.Data
{
    public class WareHouseDbContext : DbContext
    {
        public WareHouseDbContext()
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<GoodsType> GoodsType { get; set; }
        public DbSet<Storage> Storage { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ConfigHelper.GetConnectString());
        }
    }
}