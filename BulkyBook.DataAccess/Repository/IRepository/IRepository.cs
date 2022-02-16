using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        //T - Category

        //Common methods we want to implement for class T
        //(Category, for example sake, doesn't matter tho b/c it should be able to handle all)
        T GetFirstOrDefault(Expression<Func<T, bool>> filter); //GetFirstOrDefault or Find to find something from db column. T is return type
        IEnumerable<T> GetAll(); //Retrieve all categories 
        void Add(T entity); //Add specified entity
        void Remove(T entity); //Remove specified entity
        void RemoveRange(IEnumerable<T> entity); //Removes a collection of T which are entity(s)
    }

}
