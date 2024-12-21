using Microsoft.EntityFrameworkCore;
using Sportlife.Data.Entities;

namespace Sportlife.Data
{
    public class DataEFContext : DbContext
    {

        public DataEFContext(DbContextOptions<DataEFContext> options)
          : base(options) { }

        public DbSet<CityEntity> Cities { get; set; }
        public DbSet<GymEntity> Gyms { get; set; }
        public DbSet<CoachEntity> Coaches { get; set; }

    }
}
