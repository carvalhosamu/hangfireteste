
using Microsoft.EntityFrameworkCore;

namespace hangfireteste.Models
{
    public class DefaultDbContext : DbContext
    {
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options)
            : base(options)
        { }
    }
}
