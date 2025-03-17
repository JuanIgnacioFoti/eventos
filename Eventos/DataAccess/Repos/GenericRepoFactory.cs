using DataAccess.Repos;
using IDataAccess;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess
{
	public class GenericRepoFactory : IGenericRepoFactory
	{
		private readonly DbContext _context;

		public GenericRepoFactory(DbContext context)
		{
			_context = context;
		}

		public IGenericRepo<T> GetRepo<T>() where T : class
		{
			return new GenericRepo<T>(_context);
		}
	}
}