using Session08.Exercise.DAL;
using Session08.Exercise.DAL.Utilities;
using Session08.Exercise.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Session08.Exercise.EndPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new AppDbContext1();

            //نیاز به اجرای 2 دستور زیر در پکیج منیجر کنسول برای ساخته شدن دیتابیس
            //update-database -Context AppDbContext1
            //update-database -Context AppDbContext2
            //که البته میشد به جای آن از دستور زیر هم استفاده کرد
            //ctx.Database.EnsureCreated();

            //افزودن یک رکورد برای تست
            if (!ctx.Parents.Any())
            {
                ctx.Parents.Add(new Parent() { FirstName = "Milad", LastName = "Rashidi" });
                ctx.SaveChanges();
            }

            Parent entity = ctx.Parents.FirstOrDefault();

            //Call Type1: Same Context
            EfUtilities.UpdateSpecificProperties(ctx, entity, new List<string> { "fggf", "Child01", "Child02", "FirstName", "LastName" });

            //Call Type2: Different Context
            EfUtilities.UpdateSpecificProperties(entity, new List<string> { "FirstName", "LastName" });

            Console.ReadLine();
        }
    }
}
