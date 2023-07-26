using ToDoList.Data;
using ToDoList.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Dotnet6MvcLogin.Repositories.Implementation
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
        T? FindById(int id);
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }

}
