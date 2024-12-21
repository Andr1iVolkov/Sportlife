using Microsoft.EntityFrameworkCore;

namespace Sportlife.Data
{
    public class DataEFContext : DbContext
    {

        public DataEFContext(DbContextOptions<DataEFContext> options)
          : base(options) { }

    }
}
