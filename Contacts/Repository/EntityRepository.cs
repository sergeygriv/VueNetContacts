using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Contacts.Repository
{
	using Contacts.Infrastructure;
	using Contacts.Infrastructure.Exception;

	public class EntityRepository<T> : IRepository<T> where T : class
	{
		protected DbContext _dbContext;
		internal readonly IDbSet<T> _dbset;

		public EntityRepository(DbContext context)
		{
			_dbContext = context;
			_dbset = context.Set<T>();
		}

		virtual public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate) 
		{
			IQueryable<T> query = _dbset.Where(predicate);
			return query;
		}

		virtual public int Insert(T entity)
		{
			if (entity == null)
			{
				throw new ArgumentNullException("entity");
			}

			try
			{
				_dbset.Add(entity);

				return _dbContext.SaveChanges();
			}
			catch (Exception exception)
			{
				throw new RepositoryInsertException(
					string.Format("Error while inserting entity {0}.", typeof(T).Name),
					exception);
			}

		}

		virtual public void Update(T entity)
		{
			if (entity == null)
			{
				throw new ArgumentNullException("entity");
			}

			try
			{
				//Entities.Attach(entity);
				_dbContext.SaveChanges();
			}
			catch (Exception exception)
			{
				throw new RepositoryUpdateException(
					string.Format("Error while updating entity {0}.", typeof(T).Name),
					exception);
			}
		}

		virtual public void Delete(T entity)
		{
			if (entity == null)
			{
				throw new ArgumentNullException("entity");
			}

			try
			{
				_dbset.Remove(entity);
				_dbContext.SaveChanges();
			}
			catch (Exception exception)
			{
				throw new RepositoryDeleteException(
					string.Format("Error while deleting entity {0}.", typeof(T).Name),
					exception);
			}
		}

		virtual public IQueryable<T> GetAll()
		{
			return _dbset.Select(s => s);
		}

	}

}
