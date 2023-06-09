﻿using System.Linq.Expressions;

namespace NLayer.Core.Repositories
{
	public interface IGenericRepository<T> where T : class
	{
		//IQueryable'da veritabanına sorgu atmaz ne zamanki ToList(); deriz o zaman db'ye sorguyu atar. Dolayısıyla listeleyip vs sonra veritabanına atabiliriz.Daha hızlı olur.

		IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
		Task<T> GetByIdAsync(int id);
		IQueryable<T> Where(Expression<Func<T, bool>> expression);
		Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
		Task AddAsync(T entity);
		Task AddRangeAsync(IEnumerable<T> entities);
		void Update(T entity);
		void Remove(T entity);
		void RemoveRange(IEnumerable<T> entities);

	}
}
