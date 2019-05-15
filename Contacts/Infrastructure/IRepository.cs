using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace Contacts.Infrastructure
{
	public interface IRepository<T>
	{

		int Insert(T entity);

		void Update(T entity);

		void Delete(T entity);

		IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);

		IQueryable<T> GetAll();
	}
}
