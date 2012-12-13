using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cloudsifter.Data.Contracts
{
    public interface IRepositoryEntity<T> where T : IEntity
    {
        List<T> GetAll();
        T GetById(int id);
        int Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
    }
}
