﻿using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDBContext: DbContext
    {
        public NZWalksDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }

        public DbSet<Difficulty> Difficulties { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Walk> Walks { get; set; }

    }
}
