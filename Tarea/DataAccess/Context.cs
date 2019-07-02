using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Context : DbContext
    {
        
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Doctor> Doctors { get; set; }

        public Context() : base("name=ActualConnectionString")
        {
        }


        public static void cleanTables()
        {
            try
            {
                using (var context = new Context())
                {
                    context.Hospitals.Clear();
                    context.Doctors.Clear();
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
    public static class EntityExtensions
    {
        public static void Clear<T>(this DbSet<T> dbSet) where T : class
        {
            dbSet.RemoveRange(dbSet);
        }
    }

    }
}
