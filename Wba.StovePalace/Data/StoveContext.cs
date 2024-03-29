﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Wba.StovePalace.Models;

namespace Wba.StovePalace.Data
{
    public class StoveContext : DbContext
    {
        public StoveContext (DbContextOptions<StoveContext> options)
            : base(options)
        {
        }

        public DbSet<Wba.StovePalace.Models.Brand> Brand { get; set; } = default!;

        public DbSet<Wba.StovePalace.Models.Fuel> Fuel { get; set; }

        public DbSet<Wba.StovePalace.Models.Stove> Stove { get; set; }

        public DbSet<Wba.StovePalace.Models.User> User { get; set; }

        public DbSet<Wba.StovePalace.Models.Basket> Basket { get; set; }

        public DbSet<Wba.StovePalace.Models.Order> Order { get; set; }
        public DbSet<Wba.StovePalace.Models.OrderDetail> OrderDetail { get; set; }
    }
}
