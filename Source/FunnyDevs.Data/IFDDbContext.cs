﻿using FunnyDevs.Data.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace FunnyDevs.Data
{
    public interface IFDDbContext
    {
        IDbSet<User> Users { get; set; }

        IDbSet<Event> Events { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        int SaveChanges();

        void Dispose();
    }
}
