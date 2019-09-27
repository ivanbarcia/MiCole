using System.Collections.Generic;
using Web.DAL.Models;

namespace Web.BLL.Interfaces
{
    public interface IAlumnoBusiness
    {
        Alumno Find(int? id);
        IEnumerable<Alumno> GetAll();
        void Insert(Alumno entity);
        void Delete(Alumno entity);
        void Update(Alumno entity);
    }
}
