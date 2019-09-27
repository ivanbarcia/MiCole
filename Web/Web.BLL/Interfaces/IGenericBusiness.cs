using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Web.DAL.Models;

namespace Web.BLL.Interfaces
{
    public interface IGenericBusiness<T> where T : class
    {
        T Find(int? id);
        IEnumerable<T> GetAll();
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
