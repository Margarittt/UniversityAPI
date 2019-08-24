using System.Collections.Generic;

namespace UStudentAPI.Models.Repository
{
    public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        void Add(TEntity entity);
        void Update(Student student, TEntity entity);
        void Delete(Student student);
    }
}
