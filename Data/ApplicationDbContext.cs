using Microsoft.EntityFrameworkCore;
using Sakshi_Web_APP.Models;

namespace Sakshi_Web_APP.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
			//All we are doing is pass it to the base class of dbcontext

		}
		public DbSet<Categoryies> Category { get; set; }
	}
}
