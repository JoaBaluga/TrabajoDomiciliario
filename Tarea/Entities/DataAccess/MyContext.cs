using Entities;
using System.Data.Entity;

namespace DataAccess
{
    public class MyContext : DbContext
    {

        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Doctor> Doctors { get; set; }

        public MyContext() : base("name=ActualConnectionString")
        {
        }
    }
}