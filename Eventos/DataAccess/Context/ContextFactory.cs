using DataAccess.Context;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
namespace DataAccess.Test
{
	public class HomeSecurityContextFactory
	{
		public static HomeSecurityContext CreateDbContext()
		{
			var optionsBuilder = new DbContextOptionsBuilder<HomeSecurityContext>();
			optionsBuilder.UseInMemoryDatabase(databaseName: "TestDatabase");

			return new HomeSecurityContext(optionsBuilder.Options);
		}
	}
}