using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Session08.Exercise.DAL.Utilities
{
    public static class EfUtilities
    {
        public static void UpdateSpecificProperties<TContext, TEntity>(TContext ctx,
            TEntity entity, List<string> props)
            where TContext : DbContext
            where TEntity : class
        {
            if (ctx == null || entity == null) return;

            var entityType = ctx.Model.GetEntityTypes()
                .FirstOrDefault(w => w.ClrType.Name == entity.GetType().Name);

            var properties = entityType.GetProperties().Select(s => s.Name).ToList();

            foreach (var prop in props)
            {
                if (properties.Contains(prop))
                    ctx.Entry(entity).Property(prop).IsModified = true;
            }

            ctx.SaveChanges();
        }

        public static void UpdateSpecificProperties<TEntity>
            (TEntity entity, List<string> props)
            where TEntity : class
        {
            var ctx = new AppDbContext2();

            var entityType = ctx.Model.GetEntityTypes()
                .FirstOrDefault(w => w.ClrType.Name == entity.GetType().Name);

            if (entityType == null)
                throw new Exception($"There isn't any matched entity in {ctx.GetType().Name}");



            var properties = entityType.GetProperties().Select(s => s.Name).ToList();

            foreach (var prop in props)
            {
                if (properties.Contains(prop))
                    ctx.Entry(entity).Property(prop).IsModified = true;
            }

            ctx.SaveChanges();
        }
    }
}
