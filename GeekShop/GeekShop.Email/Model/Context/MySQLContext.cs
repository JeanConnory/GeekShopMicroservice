using GeekShop.Email.Model;
using Microsoft.EntityFrameworkCore;

namespace GeekShop.Email.Model.Context
{
	public class MySQLContext : DbContext
	{
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {}

        public DbSet<EmailLog> Emails { get; set; }
    }
}
